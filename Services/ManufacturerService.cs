using FirstWebApi.DTOs;

namespace FirstWebApi;

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

    public void AddManufacturer(BasicManufacturerDto manDto)
    {
        Db.AddManufacturer(manDto);
    }
}