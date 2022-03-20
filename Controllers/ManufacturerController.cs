using Microsoft.AspNetCore.Mvc;
using MW5_Project.DTOs;
using MW5_Project.Models;
using MW5_Project.Services;

namespace MW5_Project.Controllers;

[ApiController]
[Route("/[controller]")]
public class ManufacturerController : Controller
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
    public async Task<ActionResult> AddManufacturer([FromBody] BasicManufacturerDto manufacturerDto)
    {
        ManufacturerService.AddManufacturer(manufacturerDto);
        return Ok();
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> UpdateManufacturer([FromRoute] int id,
        [FromBody] BasicManufacturerDto manufacturerDto)
    {
        ManufacturerService.UpdateManufacturer(id, manufacturerDto);
        return Ok();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteManufacturer([FromRoute] int id)
    {
        ManufacturerService.DeleteManufacturer(id);
        return Ok();
    }
}