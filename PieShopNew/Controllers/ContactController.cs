using Microsoft.AspNetCore.Mvc;

namespace PieShopNew.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
