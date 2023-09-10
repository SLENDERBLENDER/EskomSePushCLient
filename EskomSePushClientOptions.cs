namespace EskomSePushClient
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Options;

    public class SePushOptionsProvider : IConfigureOptions<EskomSePushClientOptions>
    {
        readonly IConfiguration config;

        public SePushOptionsProvider(IConfiguration config)
        {
            this.config = config;
        }

        public void Configure(EskomSePushClientOptions clientOptions)
        {
            config.GetSection(nameof(EskomSePushClientOptions)).Bind(clientOptions);
        }
    }

    public class EskomSePushClientOptions
    {
        public string Token { get; set; }

        public string ApiUrl { get; set; } = "https://developer.sepush.co.za/business/";

        public string Version { get; set; } = "2.0";
    }
}
