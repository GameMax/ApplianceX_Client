using Microsoft.AspNetCore.Mvc;

namespace ApplianceX.Client.Main.ViewComponents;

public class Header : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View("/Pages/Components/HeaderComponent/HeaderView.cshtml");
    }
}