namespace DesignPatterns.Patterns.Behavioral.Strategy.Channels
{
    public class DiscordNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(string destination, string message)
        {
            Console.WriteLine("Sending Notification to channel Discord");
        }
    }
}
