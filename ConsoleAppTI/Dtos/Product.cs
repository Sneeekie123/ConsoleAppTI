namespace ConsoleAppTI.Dtos;

public class Product
{ 
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int PriceId { get; set; }

    public string Price { get; set; } = null!;

    public DateTime PriceDate { get; set; }
}
