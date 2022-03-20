using MW5_Project.DTOs;
using MW5_Project.Models;

namespace MW5_Project.Services;

public interface IGoodsService
{
    public Goods GetGoodsById(int id);
    public List<Goods> GetAllGoods();
    public void AddGoods(BasicGoodsDto goodsDto);
    public void UpdateGoods(int id, BasicGoodsDto goodsDto);

    public void DeleteGoods(int id);
}