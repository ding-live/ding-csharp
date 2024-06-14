//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace DingSDK.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public interface ISpeakeasyHttpClient
    {
        /// <summary>
        /// Sends an HTTP request asynchronously.
        /// </summary>
        /// <param name="request">The HTTP request message to send.</param>
        /// <returns>The value of the TResult parameter contains the HTTP response message.</returns>
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);

        /// <summary>
        /// Clones an HTTP request asynchronously.
        /// </summary>
        /// <remarks>
        /// This method is used in the context of Retries. It creates a new HttpRequestMessage instance
        /// as a deep copy of the original request, including its method, URI, content, headers and options.
        /// </remarks>
        /// <param name="request">The HTTP request message to clone.</param>
        /// <returns>The value of the TResult parameter contains the cloned HTTP request message.</returns>
        Task<HttpRequestMessage> CloneAsync(HttpRequestMessage request);
    }

    public class SpeakeasyHttpClient : ISpeakeasyHttpClient
    {
        protected readonly HttpClient httpClient;

        public SpeakeasyHttpClient()
        {
            httpClient = new System.Net.Http.HttpClient();
        }

        public virtual async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            return await httpClient.SendAsync(request);
        }

        public virtual async Task<HttpRequestMessage> CloneAsync(HttpRequestMessage request)
        {
            HttpRequestMessage clone = new HttpRequestMessage(request.Method, request.RequestUri);

            if (request.Content != null)
            {
                clone.Content = new ByteArrayContent(await request.Content.ReadAsByteArrayAsync());
                if (request.Content.Headers != null)
                {
                    foreach (var h in request.Content.Headers)
                    {
                        clone.Content.Headers.Add(h.Key, h.Value);
                    }
                }
            }

            foreach (KeyValuePair<string, IEnumerable<string>> header in request.Headers)
            {
                clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            foreach (KeyValuePair<string, object?> prop in request.Options)
            {
                clone.Options.TryAdd(prop.Key, prop.Value);
            }

            return clone;
        }
    }
}