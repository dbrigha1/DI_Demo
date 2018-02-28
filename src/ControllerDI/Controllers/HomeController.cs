using ControllerDI.Interfaces;
using ControllerDI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ControllerDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDay _service;
    

        public HomeController(IDay service)
        {
            _service = service;
           
        }

        public IActionResult Index()
        {
            var serverInfo = _service.Now;
            
            ViewData["Message"] = serverInfo;
            return View();
        }

        public IActionResult About([FromServices] IDateTime dateTime)
        {
            ViewData["Message"] = "Currently on the server the time is " + dateTime.Now;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
