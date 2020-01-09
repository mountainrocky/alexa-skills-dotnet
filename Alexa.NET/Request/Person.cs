﻿using System.Text.Json.Serialization;

namespace Alexa.NET.Request
{
    public class Person
    {
        [JsonPropertyName("personId")]
        public string PersonId { get; set; }

        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }
    }
}