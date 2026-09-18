namespace ConsoleApp47.Exceptions;

public class OrderNotFound : Exception
{
    public OrderNotFound(string message) : base(message)
    {
    }
}
