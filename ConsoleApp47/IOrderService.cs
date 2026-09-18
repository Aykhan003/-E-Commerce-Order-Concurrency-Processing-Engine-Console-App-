namespace ConsoleApp47;

internal interface IOrderService<T>
{
    Task<T> AddOrderAsync(T order);
    Task<T> GetOrderByIdAsync(int id);
    Task ProcessOrdersConcurrentlyAsync();
}
