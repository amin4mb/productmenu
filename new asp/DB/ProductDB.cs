
namespace new_asp;
public class ProductDB
{
    public static List<product> products = new List<product>
    {
    new product
    {
    Id = Guid.NewGuid(),
    Name = "لیوان",
    count = 5,
    Price=1000

     },
    new product
    {
    Id = Guid.NewGuid(),
    Name = "قاشق",
    count = 3,
    Price=4000
    },
    new product
    {
    Id = Guid.NewGuid(),
    Name = "چنگال",
    count = 15,
    Price=5000
    }
    };

    public static List<product> GetProducts()
    {

        return products;
    }

    public static product Get(Guid id)
    {
        return products.FirstOrDefault(x => x.Id == id); 
    }
    public static bool Delete(Guid id)
    {
        var p = products.FirstOrDefault(x => x.Id == id);
        return products.Remove(p) ;
    }

    public static void Add(product pro)
    {
        products.Add(pro);

    }
}





