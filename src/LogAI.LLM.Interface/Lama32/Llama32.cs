using System.Text.Json;

namespace LogAI.LLM.Interface.Lama32;
using Microsoft.Extensions.Configuration;

public class Llama32(HttpClient client, IConfiguration configuration) : ILlm
{
    private const string Model = "llama3.2";
    public async Task<string> SendMessage(string message)
    {
        var request = new Lama32RequestRecord(Model, message, false);

        var formattedRequest = JsonSerializer.Serialize(request);
        
        var response =  await client.PostAsync(configuration["lama32Url"], new StringContent(formattedRequest));
        
        if(!response.IsSuccessStatusCode) throw new Exception($"Lama32 API call failed with status code {response.StatusCode}");

        return await response.Content.ReadAsStringAsync();
    }
}