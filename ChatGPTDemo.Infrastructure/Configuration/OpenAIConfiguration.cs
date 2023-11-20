namespace ChatGPTDemo.Infrastructure.Configuration
{
    public class OpenAIConfiguration
    {
        public string ApiKey { get; set; }
        public string Model { get; set; }
        public string MaxTokens { get; set; }
        public string EnhancedPrompt { get; set; }
    }
}
