using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDemo.Data
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public int MaLoai { get; set; }
        [MaxLength(100)]
        public string TenLoai { get; set; }
    }

    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public int MaHH { get; set; }
        [MaxLength(100)]
        public string TenHH { get; set; }
        public string Hinh { get; set; }
        public double DonGia { get; set; } = 0;
        public int SoLuong { get; set; } = 0;        
        public int MaLoai { get; set; }

        [ForeignKey("MaLoai")]
        public Loai? Loai { get; set; }
    }
}
