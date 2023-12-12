using DesignPatterns.Models;
using DesignPatterns.Patterns.Behavioral.Strategy.Channels;

namespace DesignPatterns.Patterns.Behavioral.Strategy
{
    public class NotificationService : INotificationService
    {
        private readonly ILogger<NotificationService> _logger;
        private readonly Dictionary<string, INotificationStrategy> dicStrategy = new()
            {
                { "discord", new DiscordNotificationStrategy() },
                { "instagram", new InstagramNotificationStrategy() },
                { "email", new EmailNotificationStrategy() }
            };
        public NotificationService(
            ILogger<NotificationService> logger)
        {
            _logger = logger;
        }

        public void Notify(NotificationCommand command)
        {
            dicStrategy[command.Channel].SendNotification(command.Destination, command.Message);
        }
    }
}
