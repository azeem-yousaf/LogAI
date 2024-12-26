using LogAI.LLM.Interface;

namespace LogAIApi.Core;

public class Messages(ILlm llm)
{
    
    public async Task<string> Send(string message)
    {
        var response = await llm.SendMessage(message);
        
        return response;
    }
}