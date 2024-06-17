namespace ApplianceX.Client.Main.Models;

public class ProductModel
{
    public int SellerId { get; set; }
    
    public int CategoryId { get; set; }
    
    public int BrandId { get; set; }

    public int? ProductUid { get; set; }

    public string? Href { get; set; }

    public string? Title { get; set; }

    public string? Cover { get; set; }

    public int? Price { get; set; }

    public int? OldPrice { get; set; }

    public string? SellStatus { get; set; }

    public int? CommentsAmount { get; set; }

    public string? GroupTitle { get; set; }

    public string? GroupName { get; set; }

    public int? Discount { get; set; }
}