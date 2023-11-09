
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

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class SpeakeasyMetadata : Attribute
    {
        internal class RequestMetadata
        {
            public string? MediaType { get; set; } = null;
        }

        internal class FormMetadata
        {
            public string Style { get; set; } = "form";
            public bool Explode { get; set; } = true;
            public bool Json { get; set; } = false;
            public string Name { get; set; } = "";
        }

        internal class MultipartFormMetadata
        {
            public bool File { get; set; } = false;
            public bool Content { get; set; } = false;
            public bool Json { get; set; } = false;
            public string Name { get; set; } = "";
        }

        internal class PathParamMetadata
        {
            public string Style { get; set; } = "simple";
            public bool Explode { get; set; } = false;
            public string Name { get; set; } = "";
            public string? Serialization { get; set; } = null;
        }

        internal class QueryParamMetadata
        {
            public string Style { get; set; } = "form";
            public bool Explode { get; set; } = true;
            public string Name { get; set; } = "";
            public string? Serialization { get; set; } = null;
        }

        internal class HeaderMetadata
        {
            public string Style { get; set; } = "simple";
            public bool Explode { get; set; } = false;
            public string Name { get; set; } = "";
        }

        internal class SecurityMetadata
        {
            public string? Type { get; set; } = null;
            public string? SubType { get; set; } = null;
            public bool Option { get; set; } = false;
            public bool Scheme { get; set; } = false;
            public string Name { get; set; } = "";
        }

        public string Value { get; set; }
        private Dictionary<string, string>? metadata;

        public SpeakeasyMetadata(string value)
        {
            Value = value;
        }

        public RequestMetadata? GetRequestMetadata()
        {
            if (GetMetadata().TryGetValue("request", out var value))
            {
                var metadata = new RequestMetadata();

                ParseMetadata(value, ref metadata);

                return metadata;
            }

            return null;
        }

        public FormMetadata? GetFormMetadata()
        {
            if (GetMetadata().TryGetValue("form", out var value))
            {
                var metadata = new FormMetadata();

                ParseMetadata(value, ref metadata);

                return metadata;
            }

            return null;
        }

        public MultipartFormMetadata? GetMultipartFormMetadata()
        {
            if (GetMetadata().TryGetValue("multipartForm", out var value))
            {
                var metadata = new MultipartFormMetadata();

                ParseMetadata(value, ref metadata);

                return metadata;
            }

            return null;
        }

        public PathParamMetadata? GetPathParamMetadata()
        {
            if (GetMetadata().TryGetValue("pathParam", out var value))
            {
                var metadata = new PathParamMetadata();
                ParseMetadata(value, ref metadata);
                return metadata;
            }

            return null;
        }

        public QueryParamMetadata? GetQueryParamMetadata()
        {
            if (GetMetadata().TryGetValue("queryParam", out var value))
            {
                var metadata = new QueryParamMetadata();

                ParseMetadata(value, ref metadata);

                return metadata;
            }

            return null;
        }

        public HeaderMetadata? GetHeaderMetadata()
        {
            if (GetMetadata().TryGetValue("header", out var value))
            {
                var metadata = new HeaderMetadata();

                ParseMetadata(value, ref metadata);

                return metadata;
            }

            return null;
        }

        public SecurityMetadata? GetSecurityMetadata()
        {
            if (GetMetadata().TryGetValue("security", out var value))
            {
                var metadata = new SecurityMetadata();

                ParseMetadata(value, ref metadata);

                return metadata;
            }

            return null;
        }

        private Dictionary<string, string> GetMetadata()
        {
            if (metadata != null)
            {
                return metadata;
            }

            metadata = new Dictionary<string, string>();

            var groups = Value.Split(" ");

            foreach (var group in groups)
            {
                var parts = group.Split(":");

                if (parts.Length != 2)
                {
                    continue;
                }

                metadata.Add(parts[0], parts[1]);
            }

            return metadata;
        }

        private void ParseMetadata<T>(string raw, ref T metadata)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();

            var groups = raw.Split(",");

            foreach (var group in groups)
            {
                var parts = group.Split("=");
                var val = "";
                if (parts.Length == 2)
                {
                    val = parts[1];
                }

                values.Add(parts[0], val);
            }

            var props = typeof(T).GetProperties();

            foreach (var prop in props)
            {
                if (
                    values.TryGetValue(
                        char.ToLower(prop.Name[0]) + prop.Name.Substring(1),
                        out var value
                    )
                )
                {
                    if (prop.PropertyType == typeof(bool) || prop.PropertyType == typeof(Boolean))
                    {
                        prop.SetValue(metadata, value == "true" || value == "");
                    }
                    else
                    {
                        prop.SetValue(metadata, value);
                    }
                }
            }
        }
    }
}
