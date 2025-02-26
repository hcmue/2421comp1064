using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manage(StudentInfo model, string btnSave)
        {
            if (btnSave == "Lưu JSON")
            {
                System.IO.File.WriteAllText("student.json", System.Text.Json.JsonSerializer.Serialize(model));
            }
            return View("Index", model);
        }
    }
}
