using MW5_Project.DTOs;
using MW5_Project.Models;

namespace MW5_Project.Services;

public interface IManufacturerService
{
    public Manufacturer GetManufacturerById(int id);
    public List<Manufacturer> GetAllManufacturers();
    public void AddManufacturer(BasicManufacturerDto manufacturerDto);
    public void UpdateManufacturer(int id, BasicManufacturerDto manufacturerDto);
    public void DeleteManufacturer(int id);
}