using System;
using System.Text.Json.Serialization;

namespace ProductManager.Models
{
    internal class ApiToken
    {
        [JsonPropertyName("access_token")] public string Token { get; set; }

        [JsonPropertyName("validity")] public DateTime Validity { get; set; }
    }
}