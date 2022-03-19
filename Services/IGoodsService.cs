using FirstWebApi.DTOs;
using FirstWebApi.Models;

namespace FirstWebApi.Services;

public interface IGoodsService
{
    public Goods GetGoodsById(int id);
    public List<Goods> GetAllGoods();
    public void AddGoods(BasicGoodsDto goodsDto);
    public void UpdateGoods(int id, BasicGoodsDto goodsDto);

    public void DeleteGoods(int id);
}