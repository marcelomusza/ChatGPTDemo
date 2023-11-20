using ChatGPTDemo.Domain;
using ChatGPTDemo.Infrastructure.Configuration;
using ChatGPTDemo.Infrastructure.Interfaces;
using Microsoft.Extensions.Options;
using OpenAI_API;
using OpenAI_API.Completions;

namespace ChatGPTDemo.Infrastructure.Services
{
    public class OpenAIService : IOpenAIService
    {
        private readonly string _apiKey;
        private readonly int _maxTokens;
        private readonly string _enhancedPrompt;

        public OpenAIService(IOptions<OpenAIConfiguration> openAIConfig)
        {
            _apiKey = openAIConfig.Value.ApiKey;
            _maxTokens = int.Parse(openAIConfig.Value.MaxTokens);
            _enhancedPrompt = openAIConfig.Value.EnhancedPrompt;
        }

        public async Task<ChatGPTResponse> GetOpenAIResponseAsync(ChatGPTRequest request)
        {
            var openai = new OpenAIAPI(_apiKey);

            var prompt = _enhancedPrompt.Replace("<TheQuestion>", request.Prompt);

            var completion = new CompletionRequest
            {
                Prompt = prompt,
                Model = OpenAI_API.Models.Model.DavinciText,
                MaxTokens = _maxTokens
            };

            var result = await openai.Completions.CreateCompletionsAsync(completion);
            var answer = result.Completions.FirstOrDefault()?.Text;

            return new ChatGPTResponse { Answer = answer! };
        }
    }
}
