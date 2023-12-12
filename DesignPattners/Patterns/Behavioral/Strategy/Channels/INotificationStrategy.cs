namespace DesignPatterns.Patterns.Behavioral.Strategy.Channels
{
    public interface INotificationStrategy
    {
        void SendNotification(string destination, string message);
    }
}
