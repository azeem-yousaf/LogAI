namespace LogAI.LLM.Interface.Lama32;

internal record Lama32RequestRecord(string model, string prompt, bool stream);