namespace EskomSePushClient.Responses
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using EskomSePushClient.Models;

    internal class AreaNearbyResponse
    {
        [JsonPropertyName("areas")]
        public List<AreaNearby> Areas { get; set; }
    }
}
