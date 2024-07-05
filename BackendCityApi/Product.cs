public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal BasePrice { get; set; }
    public decimal Price => BasePrice * 1.20M; // 20% markup
}
