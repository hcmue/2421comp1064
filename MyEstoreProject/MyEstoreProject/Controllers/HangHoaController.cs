using Microsoft.AspNetCore.Mvc;
using MyEstoreProject.Entities;
using MyEstoreProject.Models;

namespace MyEstoreProject.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly MyeStoreContext _ctx;
        public HangHoaController(MyeStoreContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string? Keyword, double? FromPrice, double? ToPrice)
        {
            var result = _ctx.HangHoas.AsQueryable();
            if (!string.IsNullOrEmpty(Keyword))
            {
                result = result.Where(hh => hh.TenHh.Contains(Keyword));
            }
            if (FromPrice.HasValue)
            {
                result = result.Where(hh => hh.DonGia >= FromPrice);
            }
            if (ToPrice.HasValue)
            {
                result = result.Where(hh => hh.DonGia <= ToPrice);
            }
            var data = result.Select(hh => new HangHoaVM
            {
                MaHh = hh.MaHh,
                TenHh = hh.TenHh,
                DonGia = hh.DonGia ?? 0,
                Hinh = hh.Hinh,
                TenLoai = hh.MaLoaiNavigation.TenLoai
            }).ToList();
            return View(data);
        }
    }
}
