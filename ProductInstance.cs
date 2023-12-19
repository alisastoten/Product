using Product;

public class ProductInstance
{
    public ProductType ProductType { get; set; }
    public List<ProductFeatureInstance> Features { get; set; }

    public ProductInstance(ProductType productType)
    {
        ProductType = productType;
        Features = new List<ProductFeatureInstance>();
    }

    public void AddFeature(ProductFeatureInstance feature) =>
        Features.Add(feature);

}
