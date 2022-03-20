using MW5_Project.Database;
using MW5_Project.DTOs;
using MW5_Project.Models;

namespace MW5_Project.Services;

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
        manufacturer.Id = Db.GetManufacturersId();
        manufacturer.Name = manufacturerDto.Name;
        manufacturer.Country = manufacturerDto.Country;
        manufacturer.Description = manufacturerDto.Description;
        manufacturer.Logo = manufacturerDto.Logo;
        Db.AddManufacturer(manufacturer);
    }

    public void UpdateManufacturer(int id, BasicManufacturerDto manufacturerDto)
    {
        var manufacturer = new Manufacturer();
        manufacturer.Id = id;
        manufacturer.Name = manufacturerDto.Name;
        manufacturer.Country = manufacturerDto.Country;
        manufacturer.Description = manufacturerDto.Description;
        manufacturer.Logo = manufacturerDto.Logo;
        Db.DeleteManufacturer(id);
        Db.AddManufacturer(manufacturer);
    }

    public void DeleteManufacturer(int id)
    {
        Db.DeleteManufacturer(id);
    }
}