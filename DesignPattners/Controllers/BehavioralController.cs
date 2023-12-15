using DesignPatterns.Models;
using DesignPatterns.Patterns.Behavioral.Command;
using DesignPatterns.Patterns.Behavioral.Strategy;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BehavioralController : ControllerBase
    {
        private readonly ILogger<BehavioralController> _logger;
        private readonly INotificationService _notificationService;

        public BehavioralController(ILogger<BehavioralController> logger, INotificationService notificationService)
        {
            _logger = logger;
            _notificationService = notificationService;
        }

        [HttpPost("Strategy")]
        public IActionResult Strategy([FromBody]Notification command)
        {
            _logger.LogInformation($"BehavioralController::Strategy::Payload:: {command.Channel}");

            _notificationService.Notify(command);

            _logger.LogInformation($"BehavioralController::Strategy::Message::Message send to channel: {command.Channel}");

            return Ok($"Message send to channel: {command.Channel}");
        }

        [HttpGet("Command")]
        public IActionResult Command()
        {
            var chef = new ChefReceiver();
            var pedido = new PedidoCommand(chef, "Prato");
            var garcom = new GarcomInvoker(pedido);
            garcom.Executar();
            return Ok("Pedido realizado com sucesso");
        }
    }
}