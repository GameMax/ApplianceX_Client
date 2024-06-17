using ApplianceX.Client.Main.Models;
using ApplianceX.Client.Main.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplianceX.Client.Main.ViewComponents;

public class ProductCategory : ViewComponent
{
    private readonly IBaseParser _baseParser;
    
    public ProductCategory(IBaseParser baseParser)
    {
        _baseParser = baseParser;
    }

    public IViewComponentResult Invoke(string category)
    {
        var collection = _baseParser.ParseGet<ProductModel[]>($"http://localhost:5000/api/v1/Product/GetProductsByCategory?category={category}").Result;
        
        return View("/Pages/Components/PopularProductComponent/ProductCardView.cshtml", collection);
    }
}