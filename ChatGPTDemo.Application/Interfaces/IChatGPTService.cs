using ChatGPTDemo.Application.DTOs;
using ChatGPTDemo.Domain;

namespace ChatGPTDemo.Application.Interfaces
{
    public interface IChatGPTService
    {
        Task<ChatGPTResponseDto> GetResponseAsync(ChatGPTRequestDto request);
    }
}
