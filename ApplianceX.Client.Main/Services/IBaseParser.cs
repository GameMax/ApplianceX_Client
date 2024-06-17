namespace ApplianceX.Client.Main.Services;

public interface IBaseParser
{
    Task<T> ParseGet<T>(string url);
}