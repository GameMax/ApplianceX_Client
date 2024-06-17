using ApplianceX.Client.Main.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplianceX.Client.Main.ViewComponents;

public class CategoryMenu  : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var collection = CategoryModel.BaseCategories();
        
        return View("/Pages/Components/CategoryComponent/CategoryMenuView.cshtml", collection);
    }
}