using ChatGPTDemo.Application.Interfaces;
using System.Text.RegularExpressions;

namespace ChatGPTDemo.Application.Services
{
    public class AnswerFormatter : IAnswerFormatter
    {
        public string FormatAnswer(string answer)
        {
            if (string.IsNullOrEmpty(answer))
            {
                return string.Empty;
            }

            return Regex.Replace(answer, @"\s+", " ").Trim();
        }
    }
}
