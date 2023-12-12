using DesignPatterns.Models;
using DesignPatterns.Patterns.Behavioral.Strategy;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreationalController : ControllerBase
    {
        private readonly ILogger<CreationalController> _logger;
        private readonly INotificationService _notificationService;

        public CreationalController(ILogger<CreationalController> logger, INotificationService notificationService)
        {
            _logger = logger;
            _notificationService = notificationService;
        }

        [HttpPost(Name = "Strategy")]
        public IActionResult Strategy([FromBody]NotificationCommand command)
        {
            _notificationService.Notify(command);
            return Ok($"Message send to channel: {command.Channel}");
        }
    }
}