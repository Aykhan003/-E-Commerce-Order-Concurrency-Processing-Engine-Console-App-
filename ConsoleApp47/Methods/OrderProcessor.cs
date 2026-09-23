using ConsoleApp47.Service;

namespace ConsoleApp47.Methods;

internal class OrderProcessor<T> : IOrderService<T> where T : Order, IEntity
{
    private List<T> _orders = new List<T>();
    private readonly INotificationService _notificationService;
    private readonly object _lock = new object();
    public OrderProcessor(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    public async Task<T> AddOrderAsync(T order)
    {
        await _notificationService.NotifyAsync($"Adding order with ID: {order.Id}");
        await Task.Run(() => _orders.Add(order));
        return order;
    }

    public async Task<T> GetOrderByIdAsync(int id)
    {
        await _notificationService.NotifyAsync($"Retrieving order with ID: {id}");
        return await Task.Run(() => _orders.Find(o => o.Id == id));
    }

    public async Task ProcessOrdersConcurrentlyAsync(List<T> orders)
    {
        await Parallel.ForEachAsync(orders, async (order, cancellationToken) =>
        {
            await _notificationService.NotifyAsync($"Processing order with ID: {order.Id}");
            lock (_lock)
            {
                _orders.Add(order);
            }
        });
    }
}
