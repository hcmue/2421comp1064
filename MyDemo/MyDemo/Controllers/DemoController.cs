using Microsoft.AspNetCore.Mvc;

namespace MyDemo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UploadFile(IFormFile myfile)
        {
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", myfile.FileName);
            using(var fs = new FileStream(fullPath, FileMode.CreateNew))
            {
                myfile.CopyToAsync(fs);
            }
            return RedirectToAction("Index");
        }

        public IActionResult UploadFiles(List<IFormFile> myfiles)
        {
            foreach (var myfile in myfiles)
            {
                var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", myfile.FileName);
                using (var fs = new FileStream(fullPath, FileMode.CreateNew))
                {
                    myfile.CopyToAsync(fs);
                }
            }
            return RedirectToAction("Index");
        }
    }
}
