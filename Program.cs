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

        Console.WriteLine($"Feature type: {colorFeatureType.Name}");

        foreach (var value in colorFeatureType.PossibleValues)
            Console.WriteLine($"Option: {value}");
        
        ProductFeatureType tireFeatureType = new ProductFeatureType("Tire");
        tireFeatureType.AddPossibleValue("Winter tires");
        tireFeatureType.AddPossibleValue("Summer tires");

        Console.WriteLine($"\n\nFeature type: {tireFeatureType.Name}");

        foreach (var value in tireFeatureType.PossibleValues)
            Console.WriteLine($"Option: {value}");
        

    }
}