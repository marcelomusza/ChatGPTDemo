using ChatGPTDemo.Application.DTOs;
using ChatGPTDemo.Application.Interfaces;
using ChatGPTDemo.Domain;
using ChatGPTDemo.Infrastructure.Interfaces;

namespace ChatGPTDemo.Application.Services
{
    public class ChatGPTService : IChatGPTService
    {
        private readonly IOpenAIService _openAIService;
        private readonly IAnswerFormatter _answerFormatter;

        public ChatGPTService(IOpenAIService openAIService, IAnswerFormatter answerFormatter) 
        {
            _openAIService = openAIService;
            _answerFormatter = answerFormatter;
        } 

        public async Task<ChatGPTResponseDto> GetResponseAsync(ChatGPTRequestDto request)
        {
            var prompt = new ChatGPTRequest { Prompt = request.Prompt };

            var response = await _openAIService.GetOpenAIResponseAsync(prompt);

            return new ChatGPTResponseDto() 
            { 
                Answer = _answerFormatter.FormatAnswer(response.Answer),
            };

        }
    }
}
