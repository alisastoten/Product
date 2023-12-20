using System.Diagnostics;

namespace Product;

public class ProductType
{
    public string Name { get; set; }
    public string Description { get; set; }
    private ProductIdentifier productIdentifier; // Muutuja ProductIdentifier objekti hoidmiseks
    private List<Price> prices;

    public ProductType(string name, string description, string identifier)
    {
        Name = name;
        Description = description;
        productIdentifier = new ProductIdentifier(identifier); // Loome uue ProductIdentifier objekti
        prices = new List<Price>();
    }

    public string GetProductDetails()
    {
        return $"Product type is {Name}, Description is:\n{Description}";
    }

    public ProductIdentifier GetProductIdentifier()
    {
        return productIdentifier; // Tagastame ProductIdentifier objekti
    }

    public void AddPrice(Price price)
    {
        prices.Add(price);
    }

    public List<Price> GetPrices()
    {
        return prices;
    }

    private List<ProductInstance> instances = new List<ProductInstance>();

    public void AddInstance(ProductInstance instance)
    {
        instances.Add(instance);
    }

    public List<Price> GetAllInstancePrices()
    {
        List<Price> allPrices = new List<Price>();
        foreach (var instance in instances)
        {
            if (instance.InstancePrice != null)
            {
                allPrices.Add(instance.InstancePrice);
            }
        }
        return allPrices;
    }
}
