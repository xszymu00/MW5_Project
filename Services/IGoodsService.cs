using FirstWebApi.DTOs;

namespace FirstWebApi;

public interface IGoodsService
{
    public Goods GetGoodsById(int id);
    public List<Goods> GetAllGoods();
    public void AddGoods(BasicGoodsDto goodsDto);
}