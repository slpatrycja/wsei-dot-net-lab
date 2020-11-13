using Microsoft.AspNetCore.Mvc;

namespace wsei_dot_net_lab.Controllers
{    
    public class ItemController : Controller
    {
        [HttpGet]
        public IActionResult New()
        {
            return View();
        }
    }
}