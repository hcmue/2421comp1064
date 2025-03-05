using Lab03Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03Validation.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult CheckExistEmployee(string EmployeeNo)
        {
            var emps = new List<string> { "admin", "user", "root" };
            if (emps.Contains(EmployeeNo))
            {
                return Json($"Mã {EmployeeNo} đã có");
            }
            return Json(true);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee emp)
        {
            return View();
        }
    }
}
