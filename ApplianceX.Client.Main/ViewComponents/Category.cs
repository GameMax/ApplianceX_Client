using ApplianceX.Client.Main.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplianceX.Client.Main.ViewComponents;

public class Category : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var collection = CategoryModel.BaseCategories();
        
        return View("/Pages/Components/CategoryComponent/CategoryView.cshtml", collection);
    }
}