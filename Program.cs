using System.Net.Http.Headers;
using static System.Console;


string url = $"https://api.adviceslip.com/advice";

try
{
    using var client = new HttpClient();

    client.DefaultRequestHeaders.Add("User-agent", "David");

    var response = await client.GetAsync(url);
    response.EnsureSuccessStatusCode();
    
    var content = await response.Content.ReadAsStringAsync();

    var Dados = System.Text.Json.JsonSerializer.Deserialize<Atividade.Models.Dados>(content);

    if (Dados != null)
    {
        WriteLine($"Conselho do Dia:");
        WriteLine($"{Dados.Slip.Conselho}");
          
    }
    else
    {
        WriteLine("Informações não encontradas.");
    }

}
catch (Exception ex)
{
    WriteLine($"Erro ao consultar informações: {ex.Message}");
}