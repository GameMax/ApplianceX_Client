namespace ApplianceX.Client.Main.Models;

public class CategoryModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Cover { get; set; }

    
    
    public static List<CategoryModel> BaseCategories()
    {
        var collection = new List<CategoryModel>()
        {
            new(){Id = 1, Title = "Холодильники", Cover = "/categories/fridge_1.png"},
            new(){Id = 29, Title = "Блендери", Cover = "/categories/Blender.png"},
            new(){Id = 89, Title = "Бойлери", Cover = "/categories/Boiler.png"},
            new(){Id = 59, Title = "Сушильні машини", Cover = "/categories/Drying_machine.png"},
            new(){Id = 33, Title = "Електрочайники", Cover = "/categories/Electric_kettle.png"},
            new(){Id = 48, Title = "Вентилятори", Cover = "/categories/Fan.png"},
            new(){Id = 3, Title = "Кондиціонери", Cover = "/categories/fridge.png"},
            new(){Id = 103, Title = "Газові котли", Cover = "/categories/Gas_boiler.png"},
            new(){Id = 41, Title = "Фени", Cover = "/categories/Hair_dryer.png"},
            new(){Id = 93, Title = "Обігрівувачі", Cover = "/categories/Heater.png"},
            new(){Id = 43, Title = "Прасувальні системи", Cover = "/categories/Ironing_system.png"},
            new(){Id = 57, Title = "Соковижималки", Cover = "/categories/Juicer.png"},
            new(){Id = 87, Title = "Кухонні ваги", Cover = "/categories/Kitchen_scale.png"},
            new(){Id = 11, Title = "Кухонні плити", Cover = "/categories/Kitchen_stoves.png"},
            new(){Id = 81, Title = "Мікрохвильовки", Cover = "/categories/Microwave_oven.png"},
            new(){Id = 29, Title = "Міксери", Cover = "/categories/mixer.png"},
            new(){Id = 5, Title = "Пилососи", Cover = "/categories/Vacuum_cleaner.png"},
            new(){Id = 2, Title = "Пральні машини", Cover = "/categories/Washing_machine.png"},
        };

        return collection;
    }
}