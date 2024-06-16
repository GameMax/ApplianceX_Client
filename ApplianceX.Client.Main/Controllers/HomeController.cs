using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApplianceX.Client.Main.Models;

namespace ApplianceX.Client.Main.Controllers;

public class HomeController : Controller
{
    private readonly HttpClient _client;
    
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, IHttpClientFactory clientFactory)
    {
        _logger = logger;
        _client = clientFactory.CreateClient();
    }
    
    public async Task<IActionResult> TestConnection()
    {
        try
        {
            var response = await _client.GetAsync("http://localhost:5000/api/v1/Parser/GetItemIdsByCategoryId?categoryId=80125&page=1");
            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync();

            return Content(responseData);
        }
        catch (Exception e)
        {

            return BadRequest("Error: " + e.Message);

        }
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}