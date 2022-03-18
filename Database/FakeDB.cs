using FirstWebApi.DTOs;

namespace FirstWebApi;

public class FakeDb
{
    private List<Goods> GoodsList;
    private List<Feedback> Feedbacks;
    private List<Category> Categories;
    private List<Manufacturer> Manufacturers;

    public FakeDb()
    {
        Categories = new List<Category>
        {
            new Category
            {
                Id = 1,
                Name = "Sneakers"
            }
        };

        Feedbacks = new List<Feedback>
        {
            new Feedback
            {
                Id = 1,
                Mark = 3,
                TextFeedback = "I really like them"
            }
        };

        Manufacturers = new List<Manufacturer>
        {
            new Manufacturer
            {
                Id = 1,
                Country = "Czechia",
                Description = "Czech Sneakers Manufacturer",
                Logo = 3,
                Name = "SneakersCZ"
            }
        };


        GoodsList = new List<Goods>
        {
            new Goods
            {
                Id = 1,
                Description = "Nice Sneakers",
                Manufacturer = Manufacturers[0],
                Feedback = Feedbacks,
                Name = "Nike Sneakers",
                Photo = 3,
                PcsInStock = 5,
                Price = 1200,
                Weight = 200
            }
        };
    }

    public Goods GetGoodsById(int id)
    {
        var goods = GoodsList.FirstOrDefault(h => h.Id == id);
        return goods;
    }

    public List<Goods> GetAllGoods()
    {
        return GoodsList;
    }

    public void AddGoods(Goods goods)
    {
        GoodsList.Add(goods);
    }

    public Category GetCategoryById(int id)
    {
        var Category = Categories.FirstOrDefault(h => h.Id == id);
        return Category;
    }

    public List<Category> GetAllCategories()
    {
        return Categories;
    }

    public void AddCategory(Category category)
    {
        Categories.Add(category);
    }

    public Feedback GetFeedabackById(int id)
    {
        var Feedback = Feedbacks.FirstOrDefault(h => h.Id == id);
        return Feedback;
    }

    public List<Feedback> GetAllFeedbacks()
    {
        return Feedbacks;
    }

    public void AddFeedback(Feedback feedback)
    {
        Feedbacks.Add(feedback);
    }

    public Manufacturer GetManufacturerById(int id)
    {
        var Manufacturer = Manufacturers.FirstOrDefault(h => h.Id == id);
        return Manufacturer;
    }

    public List<Manufacturer> GetAllManufacturers()
    {
        return Manufacturers;
    }

    public void AddManufacturer(BasicManufacturerDto manufacturerDto)
    {
        var manufacturer = new Manufacturer();
        manufacturer.Name = manufacturerDto.Name;
        manufacturer.Country = manufacturerDto.Country;
        manufacturer.Description = manufacturerDto.Description;
        manufacturer.Logo = manufacturerDto.Logo;
        Manufacturers.Add(manufacturer);
    }
}