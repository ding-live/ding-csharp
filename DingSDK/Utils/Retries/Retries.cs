//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace DingSDK.Utils.Retries
{
    using System;
    using System.Net.Http;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.Errors;

    public class Retries
    {
        private Func<Task<HttpResponseMessage>> action;
        private RetryConfig retryConfig;
        private List<string> statusCodes;

        public Retries(Func<Task<HttpResponseMessage>> action, RetryConfig retryConfig, List<string> statusCodes)
        {
            this.action = action;
            this.retryConfig = retryConfig;
            this.statusCodes = statusCodes;

            if (statusCodes.Count == 0)
            {
                throw new ArgumentException("statusCodes list cannot be empty");
            }
        }

        public sealed class PermanentException : Exception
        {
            public PermanentException(Exception innerException) : base("NonRetryable error.", innerException) { }
        }

        public sealed class RetryableException : Exception
        {
            public HttpResponseMessage? Response = null;

            public RetryableException(HttpResponseMessage response) {
                Response = response;
                                                                    }

            public RetryableException(Exception innerException) : base("An error occurred.", innerException) { }
        }

        public async Task<HttpResponseMessage> Run()
        {
            switch(retryConfig.Strategy) {
                case RetryConfig.RetryStrategy.BACKOFF:
                    return await retryWithBackoff(retryConfig.RetryConnectionErrors);

                case RetryConfig.RetryStrategy.NONE:
                    return await action();

                default:
                    throw new ArgumentException("Invalid retry strategy");
            }
        }

        private async Task<HttpResponseMessage> GetResponseAsync(bool retryConnectionErrors)
        {
            try
            {
                var response = await action();

                foreach (var statusCode in statusCodes)
                {
                    if (statusCode.ToUpper().Contains("X"))
                    {
                        var codeRange = int.Parse(statusCode.Substring(0, 1));
                        var statusMajor = (int)response.StatusCode / 100;
                        if (codeRange == statusMajor)
                        {
                            throw new RetryableException(response);
                        }
                    }
                    else
                    {
                        var code = int.Parse(statusCode);
                        if (code == (int)response.StatusCode)
                        {
                            throw new RetryableException(response);
                        }
                    }
                }

                return response;
            }
            catch (RetryableException)
            {
                throw;
            }
            catch (Exception ex)
            {
                if ((ex is HttpRequestException || ex is TaskCanceledException) && retryConfig.RetryConnectionErrors)
                {
                    throw new RetryableException(ex);
                }
                throw new PermanentException(ex);
            }
        }

        private async Task<HttpResponseMessage> retryWithBackoff(bool retryConnectionErrors)
        {
            var backoff = retryConfig.Backoff;
            if(backoff == null){
                throw new ArgumentException("Backoff strategy is not defined");
            }

            var startMs = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var numAttempts = 0;

            while (true)
            {
                try
                {
                    return await GetResponseAsync(retryConnectionErrors);
                }
                catch (PermanentException ex)
                {
                    throw ex.InnerException!;
                }
                catch (RetryableException ex)
                {
                    var nowMs = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                    if (nowMs - startMs > backoff.MaxElapsedTimeMs)
                    {
                        if(ex.Response != null)
                        {
                            return ex.Response;
                        }
                        throw;
                    }

                    var intervalMs = backoff.InitialIntervalMs * Math.Pow(backoff.BaseFactor, numAttempts);
                    var jitterMs = backoff.JitterFactor * intervalMs;
                    intervalMs = intervalMs - jitterMs + new Random().NextDouble() * (2 * jitterMs + 1);
                    intervalMs = Math.Min(intervalMs, backoff.MaxIntervalMs);

                    await Task.Delay((int)intervalMs);
                    numAttempts += 1;
                }
                catch (Exception)
                {
                    throw new Exception("Unexpected error occurred.");
                }
            }
        }
    }
}