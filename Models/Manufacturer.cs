namespace FirstWebApi;

public class Manufacturer
{
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description{get; set; }
    public int Logo { get; set; }
    public string Country { get; set; }
    public List<Goods> ListOfGoods { get; set; }
}