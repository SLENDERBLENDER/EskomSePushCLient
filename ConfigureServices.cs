namespace EskomSePushClient
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    public static class ConfigureServices
    {
        public static IServiceCollection AddEskomPushClient(this IServiceCollection services)
        {
            services.ConfigureOptions<SePushOptionsProvider>();
            services.AddSingleton<IEskomSePushClient, EskomEskomSePushClientClient>();
            return services;
        }

        public static IServiceCollection AddEskomPushClient(this IServiceCollection services, Action<EskomSePushClientOptions> config)
        {
            EskomSePushClientOptions clientOptions = new EskomSePushClientOptions();
            config(clientOptions);
            services.ConfigureOptions(clientOptions);
            services.AddSingleton<IEskomSePushClient, EskomEskomSePushClientClient>();
            return services;
        }
    }
}
