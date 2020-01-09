﻿using System.Text.Json.Serialization;

namespace Alexa.NET.Request.Type
{
    public class LocationServices
    {
        [JsonPropertyName("access")]
        public LocationServiceAccess Access { get; set; }

        [JsonPropertyName("status")]
        public LocationServiceStatus Status { get; set; }
    }
}
