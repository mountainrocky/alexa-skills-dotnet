using System.Text.Json.Serialization;

namespace Alexa.NET.ConnectionTasks
{
    public class TaskStatus
    {
        public TaskStatus() { }

        public TaskStatus(int code, string message)
        {
            Code = code;
            Message = message;
        }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}