using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Alexa.NET.Request
{
    public class Device
    {
        [JsonPropertyName("deviceId")]
        public string DeviceID { get; set; }

        [JsonPropertyName("supportedInterfaces")]
        public Dictionary<string, object> SupportedInterfaces { get; set; }

        public bool IsInterfaceSupported(string interfaceName)
        {
            var hasInterface = SupportedInterfaces?.ContainsKey(interfaceName);
            return (hasInterface.HasValue ? hasInterface.Value : false); 
        }
    }
}
