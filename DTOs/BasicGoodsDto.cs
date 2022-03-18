namespace FirstWebApi.DTOs;

public class BasicGoodsDto
{
    public string Name { get; set; } = String.Empty;
    public int Photo { get; set; }
    public string? Description { get; set; }
    public float Price { get; set; }
    public float Weight { get; set; }
    public int PcsInStock { get; set; }
}