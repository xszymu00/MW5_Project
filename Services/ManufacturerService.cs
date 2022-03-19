using FirstWebApi.Database;
using FirstWebApi.DTOs;
using FirstWebApi.Models;

namespace FirstWebApi.Services;

public class ManufacturerService : IManufacturerService
{
    private readonly FakeDb Db;

    public ManufacturerService(FakeDb Db)
    {
        this.Db = Db;
    }

    public Manufacturer GetManufacturerById(int id)
    {
        return Db.GetManufacturerById(id);
    }

    public List<Manufacturer> GetAllManufacturers()
    {
        return Db.GetAllManufacturers();
    }

    public void AddManufacturer(BasicManufacturerDto manufacturerDto)
    {
        var manufacturer = new Manufacturer();
        manufacturer.Name = manufacturerDto.Name;
        manufacturer.Country = manufacturerDto.Country;
        manufacturer.Description = manufacturerDto.Description;
        manufacturer.Logo = manufacturerDto.Logo;
        Db.AddManufacturer(manufacturer);
    }
}