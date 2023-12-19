namespace Product;

public class ProductType
{
    public string Name { get; set; }
    public string Description { get; set; }
    private ProductIdentifier productIdentifier; // Muutuja ProductIdentifier objekti hoidmiseks

    public ProductType(string name, string description, string identifier)
    {
        Name = name;
        Description = description;
        productIdentifier = new ProductIdentifier(identifier); // Loome uue ProductIdentifier objekti
    }

    public string GetProductDetails()
    {
        return $"Product type is {Name}, Description is:\n{Description}";
    }

    public ProductIdentifier GetProductIdentifier()
    {
        return productIdentifier; // Tagastame ProductIdentifier objekti
    }
}
