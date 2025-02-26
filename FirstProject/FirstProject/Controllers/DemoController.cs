using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstProject.Controllers
{
    public class DemoController : Controller
    {
        public async Task<IActionResult> Test2()
        {
            var sw = new Stopwatch();
            sw.Start();
            var demo = new Demo();
            var a = demo.AsyncA();
            var b = demo.AsyncB();
            var c = demo.AsyncC();
            await a; await b; await c;            
            sw.Stop();
            return Content($"Chạy hết {sw.ElapsedMilliseconds} ms");
        }
        public IActionResult Test1()
        {
            var sw = new Stopwatch();
            sw.Start();
            var demo = new Demo();
            demo.A();
            demo.B();
            demo.C();
            sw.Stop();
            return Content($"Chạy hết {sw.ElapsedMilliseconds} ms");
        }
    }
}
