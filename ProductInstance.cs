using Product;
using System.Diagnostics;

public class ProductInstance
{
    public ProductType ProductType { get; set; }
    public List<ProductFeatureInstance> Features { get; set; }
    public Price InstancePrice { get; set; }

    public ProductInstance(ProductType productType, Price price)
    {
        ProductType = productType;
        Features = new List<ProductFeatureInstance>();
        InstancePrice = price;
    }

    public void AddFeature(ProductFeatureInstance feature) =>
        Features.Add(feature);

}
