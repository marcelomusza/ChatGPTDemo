using ChatGPTDemo.Infrastructure.Interfaces;
using ChatGPTDemo.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace ChatGPTDemo.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IOpenAIService, OpenAIService>();

            return services;
        }
    }
}