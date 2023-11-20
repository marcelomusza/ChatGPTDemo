using ChatGPTDemo.Application.Interfaces;
using ChatGPTDemo.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ChatGPTDemo.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IChatGPTService, ChatGPTService>();
            services.AddScoped<IAnswerFormatter, AnswerFormatter>();

            return services;
        }
    }
}
