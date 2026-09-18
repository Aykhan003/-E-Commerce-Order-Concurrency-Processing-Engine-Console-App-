namespace ConsoleApp47;

internal class Order : IEntity
{
    public static int _idCounter;
    public int Id { get;}
    public CustomerRecord Customer { get; init; } = null!;
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    public OrderStatus Status { get; set; }
    public readonly DateTime OrderDate;
    public decimal TotalAmount => Items.Sum(item => item.Price * item.Quantity);
    public Order()
    {
        
    }
    public OrderItem this[int index]
    {
        get => Items[index];
        set => Items[index] = value;
    }
    public static explicit operator decimal(Order order)
    {
        return order.TotalAmount;
    }
    public static implicit operator string(Order order)
    {
        return $"Order ID: {order.Id}, Customer: {order.Customer.FullName}, Total Amount: {order.TotalAmount:C}, Status: {order.Status}";
    }
}
