namespace ConsoleApp47.Service;

public class EmailNotificationService : INotificationService
{
    public async Task NotifyAsync(string message)
    {
        Console.WriteLine($"Email Notification: {message}");
        await Task.Delay(1000);
    }
}
