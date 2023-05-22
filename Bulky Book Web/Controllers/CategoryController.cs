using Bulky_Book_Web.Models;
using BulkyBookWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace Bulky_Book_Web.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
