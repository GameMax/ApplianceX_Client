using Microsoft.AspNetCore.Mvc;

namespace ApplianceX.Client.Main.ViewComponents;

public class Footer : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View("/Pages/Components/FooterComponent/FooterView.cshtml");
    }
}