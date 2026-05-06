using Microsoft.AspNetCore.Mvc;
using MyEnterpriseApp.Services;

namespace MyEnterpriseApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IMessageService messageService, ILogger<HomeController> logger)
        {
            _messageService = messageService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Home page accessed");

            var model = _messageService.GetAppInfo();

            return View(model);
        }
    }
}
