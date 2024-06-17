using ApplianceX.Client.Main.Models;
using ApplianceX.Client.Main.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplianceX.Client.Main.ViewComponents;

public class PopularProduct : ViewComponent
{
    private readonly IBaseParser _baseParser;
    
    public PopularProduct(IBaseParser baseParser)
    {
        _baseParser = baseParser;
    }

    public IViewComponentResult Invoke()
    {
        var collection = _baseParser.ParseGet<ProductModel[]>("http://localhost:5000/api/v1/Product/GetPopularProducts").Result;
        
        return View("/Pages/Components/PopularProductComponent/ProductCardView.cshtml", collection);
    }
}