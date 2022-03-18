using FirstWebApi.DTOs;

namespace FirstWebApi;

public interface IManufacturerService
{
    public Manufacturer GetManufacturerById(int id);
    public List<Manufacturer> GetAllManufacturers();
    public void AddManufacturer(BasicManufacturerDto manDto);
}