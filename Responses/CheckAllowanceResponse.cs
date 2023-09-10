namespace EskomSePushClient.Responses
{
    using System.Text.Json.Serialization;
    using EskomSePushClient.Models;

    internal class CheckAllowanceResponse
    {
        [JsonPropertyName("allowance")]
        public Allowance Allowance { get; set; }
    }
}
