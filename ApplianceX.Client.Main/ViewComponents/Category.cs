using ApplianceX.Client.Main.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplianceX.Client.Main.ViewComponents;

public class Category : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var collection = new List<CategoryModel>()
        {
            new(){Title = "Холодильники", Cover = "/categories/fridge_1.png"},
            new(){Title = "Блендери", Cover = "/categories/Blender.png"},
            new(){Title = "Бойлери", Cover = "/categories/Boiler.png"},
            new(){Title = "Сушильні машини", Cover = "/categories/Drying_machine.png"},
            new(){Title = "Електрочайники", Cover = "/categories/Electric_kettle.png"},
            new(){Title = "Вентилятори", Cover = "/categories/Fan.png"},
            new(){Title = "Кондіціонери", Cover = "/categories/Fridge.png"},
            new(){Title = "Газові котли", Cover = "/categories/Gas_boiler.png"},
            new(){Title = "Фени", Cover = "/categories/Hair_dryer.png"},
            new(){Title = "Обігрівувачі", Cover = "/categories/Heater.png"},
            new(){Title = "Прасувальні системи", Cover = "/categories/Ironing_system.png"},
            new(){Title = "Соковижималки", Cover = "/categories/Juicer.png"},
            new(){Title = "Кухонні ваги", Cover = "/categories/Kitchen_scale.png"},
            new(){Title = "Кухонні плити", Cover = "/categories/Kitchen_stoves.png"},
            new(){Title = "Мікрохвильовки", Cover = "/categories/Microwave_oven.png"},
            new(){Title = "Міксери", Cover = "/categories/mixer.png"},
            new(){Title = "Пилососи", Cover = "/categories/Vacuum_cleaner.png"},
            new(){Title = "Стиральні машини", Cover = "/categories/Washing_machine.png"},
        };
        
        return View("/Pages/Components/CategoryComponent/CategoryView.cshtml", collection);
    }
}