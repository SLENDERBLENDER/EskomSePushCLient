namespace EskomSePushClient.Responses
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using EskomSePushClient.Models;

    internal class AreaSearchResponse
    {
        [JsonPropertyName("areas")]
        public List<Area> Areas { get; set; }
    }
}
