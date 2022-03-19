using FirstWebApi.DTOs;
using FirstWebApi.Models;

namespace FirstWebApi.Services;

public interface IManufacturerService
{
    public Manufacturer GetManufacturerById(int id);
    public List<Manufacturer> GetAllManufacturers();
    public void AddManufacturer(BasicManufacturerDto manDto);
}