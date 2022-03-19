using FirstWebApi.DTOs;
using FirstWebApi.Models;
using FirstWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers;


[Route("/[controller]")]
[ApiController()]

public class GoodsController : Controller
{
    private readonly IGoodsService goodsService;

    public GoodsController(IGoodsService goodsService)
    {
        this.goodsService = goodsService;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Goods>>> GetGoods()
    {
        List<Goods> GoodsList = goodsService.GetAllGoods();
        if (GoodsList == null)
            return NotFound();
        return Ok(GoodsList);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Goods>> GetGoodsById(int id)
    {
        var goods = goodsService.GetGoodsById(id);
        return Ok((goods));
    }

    [HttpPost("add")]
    public async Task<ActionResult> AddGoods([FromBody] BasicGoodsDto goodsDto)
    {
        goodsService.AddGoods(goodsDto);
        return Ok();
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> UpdateGoods([FromRoute] int id, [FromBody] BasicGoodsDto goodsDto)
    {
        goodsService.UpdateGoods(id,goodsDto);
        return Ok();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteGoods([FromRoute] int id)
    {
        goodsService.DeleteGoods(id);
        return Ok();
    }
}