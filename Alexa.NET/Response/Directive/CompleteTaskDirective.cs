using System.Text.Json.Serialization;
using Alexa.NET.ConnectionTasks;

namespace Alexa.NET.Response.Directive
{
    public class CompleteTaskDirective:IDirective
    {
        public CompleteTaskDirective() { }

        public CompleteTaskDirective(int statusCode, string statusMessage)
        {
            Status = new TaskStatus(statusCode,statusMessage);
        }

        [JsonPropertyName("type")]
        public string Type => "Tasks.CompleteTask";

        [JsonPropertyName("status")]
        public TaskStatus Status { get; set; } 
    }
}
