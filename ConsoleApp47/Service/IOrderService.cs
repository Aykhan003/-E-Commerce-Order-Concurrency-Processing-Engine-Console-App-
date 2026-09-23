namespace ConsoleApp47.Service;

internal interface IOrderService<T>
{
    Task<T> AddOrderAsync(T order);
    Task<T> GetOrderByIdAsync(int id);
    Task ProcessOrdersConcurrentlyAsync(List<T> orders);
}
