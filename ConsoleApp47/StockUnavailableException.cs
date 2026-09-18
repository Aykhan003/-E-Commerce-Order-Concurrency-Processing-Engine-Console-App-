namespace ConsoleApp47;

public class StockUnavailableException : Exception
{
    public StockUnavailableException(string message) : base(message)
    {
    }
}
