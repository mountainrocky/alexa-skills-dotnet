﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive
{
    public class JsonDirective:IDirective
    {
        public JsonDirective() { }

        public JsonDirective(string type)
        {
            Type = type;
        }

        public string Type { get; }

        [JsonExtensionData]
        public Dictionary<string, object> Properties { get; set; } = new Dictionary<string, object>();
    }
}
