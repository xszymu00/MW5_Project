using FirstWebApi.Models;

namespace FirstWebApi.Database;

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

    public void DeleteGoods(int id)
    {
        GoodsList.Remove(GoodsList.Where(goods => goods.Id == id).First());
    }

    public void UpdateGoods(int id, Goods goods)
    {
        DeleteGoods(id);
        GoodsList.Add(goods);
        
    }

    public int getGoodsId()
    {
        int result = GoodsList.Last().Id+1;
        return result;
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

    public void AddManufacturer(Manufacturer manufacturer)
    {
        Manufacturers.Add(manufacturer);
    }
}