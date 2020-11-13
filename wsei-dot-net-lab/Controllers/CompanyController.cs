using Microsoft.AspNetCore.Mvc;
using wsei_dot_net_lab.Models;

namespace wsei_dot_net_lab.Controllers
{
    public class CompanyController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CompanyModel company)
        {
            var vievModel = new CompanyAddedViewModel
            {
                NumberOfCharsInName = company.Name.Length,
                NumberOfCharsInDescription = company.Description.Length,
                IsHidden = !company.IsVisible
            };
            
            return View("CompanyAdded", vievModel);
        }
    }
}