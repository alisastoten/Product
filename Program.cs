using Product;

class Program
{
    static void Main(string[] args)
    {
        ProductFeatureType colorFeatureType = new ProductFeatureType("Color");
        colorFeatureType.AddPossibleValue("Black");
        colorFeatureType.AddPossibleValue("Red");
        colorFeatureType.AddPossibleValue("Silver");
        colorFeatureType.AddPossibleValue("Blue");
        colorFeatureType.AddPossibleValue("Pink");


        Console.WriteLine($"Feature type - {colorFeatureType.Name}:\n");

        foreach (var value in colorFeatureType.PossibleValues)
            Console.WriteLine($"- {value}");

        Console.Write("\n-----------------------");

        
        ProductFeatureType tireFeatureType = new ProductFeatureType("Tire");
        tireFeatureType.AddPossibleValue("Winter tires");
        tireFeatureType.AddPossibleValue("Summer tires");


        Console.WriteLine($"\n\nFeature type - {tireFeatureType.Name}:\n");

        foreach (var value in tireFeatureType.PossibleValues)
            Console.WriteLine($"- {value}");

        Console.Write("\n-----------------------");
        // Create a ProductType
        ProductType TypeAudiA6 = new ProductType("Audi A6", "Audi model A6", "EEEEEE");

        // Create ProductInstances with prices
        ProductInstance instance1 = new ProductInstance(TypeAudiA6, new Price(49999, DateTime.Now, DateTime.Now.AddYears(1)));
        ProductInstance instance2 = new ProductInstance(TypeAudiA6, new Price(51999, DateTime.Now, DateTime.Now.AddYears(1)));
        ProductInstance instance3 = new ProductInstance(TypeAudiA6, new Price(59999, DateTime.Now, DateTime.Now.AddYears(1)));

        // Add instances to the product type
        TypeAudiA6.AddInstance(instance1);
        TypeAudiA6.AddInstance(instance2);
        TypeAudiA6.AddInstance(instance3);

        // Get all prices
        List<Price> prices = TypeAudiA6.GetAllInstancePrices();

        Console.WriteLine($"\n\n{TypeAudiA6.Name} product type prices\n");
        // Display prices
        foreach (var price in prices)
        {
            Console.WriteLine($"Price: {price.Amount}");
        }

        Console.Write("\n-----------------------");


    }
}