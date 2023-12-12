namespace DesignPatterns.Models
{
    public class NotificationCommand
    {
        public string Channel { get; set; }
        public string Destination { get; set; }
        public string Message { get; set; }
    }
}
