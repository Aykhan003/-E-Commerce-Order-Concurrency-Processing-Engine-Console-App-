namespace ConsoleApp47;

internal class OrderItem
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public OrderItem DeepCopy()
    {
        return new OrderItem
        {
            ProductId = this.ProductId,
            ProductName = this.ProductName,
            Price = this.Price,
            Quantity = this.Quantity
        };
    }
}
