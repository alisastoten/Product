
namespace Product;

public class Price
{
    public double Amount { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }

    public Price(double amount, DateTime validFrom, DateTime validTo) 
    { 
        Amount = amount;
        ValidFrom = validFrom;
        ValidTo = validTo;
    }
}

