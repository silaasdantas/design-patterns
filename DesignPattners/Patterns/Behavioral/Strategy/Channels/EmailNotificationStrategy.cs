namespace DesignPatterns.Patterns.Behavioral.Strategy.Channels
{
    public class EmailNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(string destination, string message)
        {
            Console.WriteLine("Sending Notification to channel Email");
        }
    }
}
