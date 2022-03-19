using FirstWebApi.DTOs;
using FirstWebApi.Models;
using FirstWebApi.Services;
using Microsoft.AspNetCore.Mvc;
namespace FirstWebApi.Controllers;

[ApiController]
[Route("/[controller]")]
public class ManufacturerController:Controller
{
    private readonly IManufacturerService ManufacturerService; 
    public ManufacturerController(IManufacturerService manufacturerService)
    {
        this.ManufacturerService = manufacturerService;
    }
    [HttpGet()]
    public async Task<ActionResult<List<Manufacturer>>> GetManufacturers()
    {
        List<Manufacturer> manufacturers = ManufacturerService.GetAllManufacturers();
        return Ok(manufacturers);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Manufacturer>> GetManufacturersById(int id)
    {
        var manufacturer = ManufacturerService.GetManufacturerById(id);
        if (manufacturer == null)
        {

            return NotFound();
        }
        return Ok((manufacturer));
    }

    [HttpPost("add")]
    public async Task<ActionResult> AddGoods([FromBody] BasicManufacturerDto manufacturerDto)
    {
        ManufacturerService.AddManufacturer(manufacturerDto);
        return Ok();
    }
    
}