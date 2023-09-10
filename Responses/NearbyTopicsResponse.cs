namespace EskomSePushClient.Responses
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using EskomSePushClient.Models;

    internal class NearbyTopicsResponse
    {
        [JsonPropertyName("topics")]
        public List<Topic> Topics { get; set; }
    }
}
