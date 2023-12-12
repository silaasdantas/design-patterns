namespace DesignPatterns.Patterns.Behavioral.Strategy.Channels
{
    public class InstagramNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(string destination, string message)
        {
            Console.WriteLine("Sending Notification to channel Instagram");
        }
    }
}
