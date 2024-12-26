namespace LogAI.LLM.Interface;

public interface ILlm
{
    public Task<string> SendMessage(string message);
}