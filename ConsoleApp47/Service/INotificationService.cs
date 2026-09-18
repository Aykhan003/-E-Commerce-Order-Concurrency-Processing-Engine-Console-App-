namespace ConsoleApp47.Service;

internal interface INotificationService
{
    Task NotifyAsync(string message);
}
