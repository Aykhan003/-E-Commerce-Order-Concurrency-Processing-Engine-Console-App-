using ConsoleApp47.Service;

namespace ConsoleApp47.Methods;

internal class OrderProfessor<T> : IOrderService<T> where T : Order, IEntity
{
    private List<T> _orders = new List<T>();
    private readonly INotificationService _notificationService;
    public OrderProfessor(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    public Task<T> AddOrderAsync(T order)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetOrderByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task ProcessOrdersConcurrentlyAsync()
    {
        throw new NotImplementedException();
    }
}
