using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Directive
{
    public class VideoAppDirective:IDirective
    {
        public VideoAppDirective()
        {
        }

        public VideoAppDirective(string source)
        {
            VideoItem = new VideoItem(source);
        }

        [JsonPropertyName("type")]
        public string Type => "VideoApp.Launch";

        [JsonPropertyName("videoItem")]//,Required = Required.Always)]
        public VideoItem VideoItem { get; set; }
    }
}
