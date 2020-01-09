﻿using System.Text.Json.Serialization;
using Alexa.NET.Request;

namespace Alexa.NET.Response.Directive
{
    public class DialogConfirmSlot : IDirective
    {
        [JsonPropertyName("type")]
        public string Type => "Dialog.ConfirmSlot";

        [JsonPropertyName("slotToConfirm")]//, JsonRequired]
        public string SlotName { get; set; }

        [JsonPropertyName("updatedIntent")]
        public Intent UpdatedIntent { get; set; }

        public DialogConfirmSlot(string slotName)
        {
            SlotName = slotName;
        }

        internal DialogConfirmSlot()
        {
        }
    }
}