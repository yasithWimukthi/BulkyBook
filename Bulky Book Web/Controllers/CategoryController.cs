using Microsoft.AspNetCore.Mvc;

namespace Bulky_Book_Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
