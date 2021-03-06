using MW5_Project.Models;

namespace MW5_Project.Database;

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
                Id = 0,
                Name = "Sneakers"
            }
        };

        Feedbacks = new List<Feedback>
        {
            new Feedback
            {
                Id = 0,
                Mark = 3,
                TextFeedback = "I really like them"
            }
        };

        Manufacturers = new List<Manufacturer>
        {
            new Manufacturer
            {
                Id = 0,
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
                Id = 0,
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
        var goods = GoodsList.FirstOrDefault(goods1 => goods1.Id == id);
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

    public void DeleteGoods(int id)
    {
        GoodsList.Remove(GetGoodsById(id));
    }
    public int GetGoodsId()
    {
        int id = GoodsList.Last().Id+1;
        return id;
    }

    public Category GetCategoryById(int id)
    {
        var category = Categories.FirstOrDefault(category => category.Id == id);
        return category;
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
        var feedback = Feedbacks.FirstOrDefault(feedback => feedback.Id == id);
        return feedback;
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
        var manufacturer = Manufacturers.FirstOrDefault(manufacturer =>  manufacturer.Id == id);
        return manufacturer;
    }

    public List<Manufacturer> GetAllManufacturers()
    {
        return Manufacturers;
    }

    public void AddManufacturer(Manufacturer manufacturer)
    {
        Manufacturers.Add(manufacturer);
    }

    public void DeleteManufacturer(int id)
    {
        Manufacturers.Remove(GetManufacturerById(id));
    }

    public int GetManufacturersId()
    {
        int id = Manufacturers.Last().Id + 1;
        return id;
    }
}