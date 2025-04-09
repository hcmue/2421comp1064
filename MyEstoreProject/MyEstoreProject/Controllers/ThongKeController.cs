using Microsoft.AspNetCore.Mvc;
using MyEstoreProject.Entities;

namespace MyEstoreProject.Controllers
{
    public class ThongKeController : Controller
    {
        private readonly MyeStoreContext _ctx;
        public ThongKeController(MyeStoreContext ctx)
        {
            _ctx = ctx;
        }

        const int KHOANG_CACH_NGAY = 30;
        public IActionResult ThongKeTheoLoai(DateTime? TuNgay, DateTime? DenNgay)
        {
            if (!TuNgay.HasValue && !DenNgay.HasValue)
            {
                DenNgay = DateTime.Now;
                TuNgay = DenNgay.Value.AddDays(-KHOANG_CACH_NGAY);
            }
            else if (TuNgay.HasValue && !DenNgay.HasValue)
            {
                DenNgay = TuNgay.Value.AddDays(KHOANG_CACH_NGAY);
            }
            else if (!TuNgay.HasValue && DenNgay.HasValue)
            {
                TuNgay = DenNgay.Value.AddDays(-KHOANG_CACH_NGAY);
            }
            var data = _ctx.ChiTietHds
                .Where(p => p.MaHdNavigation.NgayDat >= TuNgay && p.MaHdNavigation.NgayDat <= DenNgay)
                .GroupBy(cthd => new
                {
                    MaLoai = cthd.MaHhNavigation.MaLoai,
                    TenLoai = cthd.MaHhNavigation.MaLoaiNavigation.TenLoai,
                }).Select(p => new
                {
                    p.Key.MaLoai,
                    p.Key.TenLoai,
                    DoanhThu = p.Sum(cthd => cthd.SoLuong * cthd.DonGia)
                });
            return Json(data);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
