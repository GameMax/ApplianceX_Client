using System.Text.Json;

namespace ApplianceX.Client.Main.Services;

public class BaseParser : IBaseParser
{
    private readonly HttpClient _client;
    private readonly ILogger<BaseParser> _logger;

    public BaseParser(HttpClient client, ILogger<BaseParser> logger)
    {
        _client = client;
        _logger = logger;
    }


    public async Task<T> ParseGet<T>(string url)
    {
        var response = await _client.GetAsync(url);
        var scriptText = await response.Content.ReadAsStringAsync();

        var appData = JsonSerializer.Deserialize<T>(scriptText, JsonSerializerOptions);

        return appData;
    }

    private static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };
}