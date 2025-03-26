using System;
using System.Collections.Generic;

namespace MyEstoreProject.Entities
{
    public partial class CauHinh
    {
        public int Id { get; set; }
        public int? SoSanPham1Trang { get; set; }
        public int? SoTrang { get; set; }
        public int? SoNgayHetHanQc { get; set; }
    }
}
