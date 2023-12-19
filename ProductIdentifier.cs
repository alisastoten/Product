public class ProductIdentifier
{
    private string _productIdentifier;

    public ProductIdentifier(string productIdentifier)
    {
        _productIdentifier = productIdentifier;
    }

    public string GetIdentifier()
    {
        return _productIdentifier;
    }
}