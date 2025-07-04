/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using Newtonsoft.Json;

namespace EdFi.OdsApi.Sdk.v71.Client.Auth
{
    class TokenResponse
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("expires_in")]
        public int? ExpiresIn { get; set; }
        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("refresh_token")]
        public string? RefreshToken { get; set; }

        public DateTime? ExpiresAt => ExpiresIn == null ? null : Created?.AddSeconds(ExpiresIn.Value);
    }
}