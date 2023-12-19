﻿namespace Product;

public class ProductFeatureType // color, tiretype
{
    public string Name { get; set; }
    public List<object> PossibleValues { get; private set; } 

    public ProductFeatureType(string name)
    {
        Name = name;
        PossibleValues = new List<object>();
    }

    public void AddPossibleValue(object value)
    {
        PossibleValues.Add(value);
    }
}