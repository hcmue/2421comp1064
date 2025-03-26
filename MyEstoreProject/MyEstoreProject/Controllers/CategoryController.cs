using Microsoft.AspNetCore.Mvc;
using MyEstoreProject.Entities;

namespace MyEstoreProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyeStoreContext _context;

        public CategoryController(MyeStoreContext context)
        {
            _context = context;
        }


        // GET /Category
        public IActionResult Index()
        {
            return View(_context.Loais.ToList());
        }

        // GET /Category/Search
        [HttpGet("/Category/Search")]
        public IActionResult Search(string q)
        {
            var data = _context.Loais.AsQueryable();
            if (!string.IsNullOrEmpty(q))
            {
                data = data.Where(p => p.TenLoai.Contains(q));
            }
            return View("Index", data.ToList());
        }
    }
}
