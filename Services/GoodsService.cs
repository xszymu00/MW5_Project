using FirstWebApi.DTOs;

namespace FirstWebApi;

public class GoodsService:IGoodsService
{
    private FakeDb Db;

    public GoodsService(FakeDb Db)
    {
        this.Db = Db;
    }
    
    public Goods GetGoodsById(int id)
    
    {
        return Db.GetGoodsById(id);
    }

    public List<Goods> GetAllGoods()
    {
        return Db.GetAllGoods();
    }

    public void AddGoods(BasicGoodsDto goodsDto)
    {
        Goods goods = new Goods();
        goods.Name = goodsDto.Name;
        goods.Photo = goodsDto.Photo;
        goods.Price = goodsDto.Price;
        goods.Weight = goodsDto.Weight;
        goods.PcsInStock = goodsDto.PcsInStock;
        goods.Description = goodsDto.Description;
        Db.AddGoods(goods);
    }

}