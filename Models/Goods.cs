namespace FirstWebApi;

public class Goods
{
    public Goods()
    {
        
    }
    public Goods(int photo, string? description, float price, float weight, int pcsInStock)
    {
        Photo = photo;
        Description = description;
        Price = price;
        Weight = weight;
        PcsInStock = pcsInStock;
    }

    public int Id { get; init; }
    public string Name { get; set; } = String.Empty;
    public int Photo { get; set; }
    public string? Description { get; set; }
    public float Price { get; set; }
    public float Weight { get; set; }
    public int PcsInStock { get; set; }
    public List<Category>? Category { get; set; }
    public Manufacturer? Manufacturer { get; set; }
    public List<Feedback>? Feedback { get; set; }
}