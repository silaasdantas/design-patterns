
using DesignPatterns.Models;

namespace DesignPatterns.Patterns.Behavioral.Strategy
{
    public interface INotificationService
    {
        void Notify(Notification command);
    }
}
