using MW5_Project.Database;
using MW5_Project.DTOs;
using MW5_Project.Models;

namespace MW5_Project.Services;

public class GoodsService:IGoodsService
{
    private readonly FakeDb Db;

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
        goods.Id = Db.GetGoodsId();
        goods.Name = goodsDto.Name;
        goods.Photo = goodsDto.Photo;
        goods.Price = goodsDto.Price;
        goods.Weight = goodsDto.Weight;
        goods.PcsInStock = goodsDto.PcsInStock;
        goods.Description = goodsDto.Description;
        Db.AddGoods(goods);
    }

    public void UpdateGoods(int id, BasicGoodsDto goodsDto)
    {
        Goods goods = new Goods();
        goods.Id = id;
        goods.Name = goodsDto.Name;
        goods.Photo = goodsDto.Photo;
        goods.Price = goodsDto.Price;
        goods.Weight = goodsDto.Weight;
        goods.PcsInStock = goodsDto.PcsInStock;
        goods.Description = goodsDto.Description;
        Db.DeleteGoods(id);
        Db.AddGoods(goods);
    }

    public void DeleteGoods(int id)
    {
        Db.DeleteGoods(id);
    }
}