namespace EskomSePushClient.Responses
{
    using System.Text.Json.Serialization;
    using EskomSePushClient.Models;

    public class StatusResponse
    {
        [JsonPropertyName("status")] 
        public Status Status { get; set; } = null!;
    }
}
