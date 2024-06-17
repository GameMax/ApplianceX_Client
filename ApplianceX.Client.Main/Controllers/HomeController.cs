using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApplianceX.Client.Main.Models;
using ApplianceX.Client.Main.Services;

namespace ApplianceX.Client.Main.Controllers;

public class HomeController : Controller
{
    private readonly IBaseParser _baseParser;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, IBaseParser baseParser)
    {
        _logger = logger;
        _baseParser = baseParser;
    }
    
    
    public async Task<IActionResult> OpenCategory(string category)
    {
        var collection = await _baseParser.ParseGet<ProductModel[]>($"http://localhost:5000/api/v1/Product/GetProductsByCategory?category={category}");

        ViewBag.CategoryTitle = category;
        ViewBag.ItemCount = collection.Length;
        
        return View("CategoryIndex", collection);
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