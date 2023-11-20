using ChatGPTDemo.Application.DTOs;
using ChatGPTDemo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChatGPT_IntegrationTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatGPTController : ControllerBase
    {
        private readonly IChatGPTService _chatGPTService;

        public ChatGPTController(IChatGPTService chatGPTService)
        {
            _chatGPTService = chatGPTService;
        }

        [HttpPost]
        public async Task<IActionResult> GenerateAIBasedResultAsync([FromBody] ChatGPTRequestDto requestDto)
        {           
            var response = await _chatGPTService.GetResponseAsync(requestDto);
            return Ok(response.Answer);            
        }
    }
}
