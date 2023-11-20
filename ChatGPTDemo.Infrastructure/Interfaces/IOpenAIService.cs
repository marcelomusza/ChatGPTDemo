using ChatGPTDemo.Domain;

namespace ChatGPTDemo.Infrastructure.Interfaces
{
    public interface IOpenAIService
    {
        Task<ChatGPTResponse> GetOpenAIResponseAsync(ChatGPTRequest request);
    }
}
