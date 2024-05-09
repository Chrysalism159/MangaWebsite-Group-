using AnimeWebsite.StaticValue;
using System.ComponentModel.DataAnnotations;

namespace AnimeWebsite.Data
{
    
    public class Truyen
    {
        [Display(Name = "Tên truyện")]
        [Required(ErrorMessage = "Chưa nhập tên truyện")]
        [MaxLength(20, ErrorMessage = "Tối đa 20 kí tự")]
        public string maTruyen { get; set; }
        public string maNguoiDangTai {  get; set; }

        public string tenTruyen { get; set; }
        public TheLoai theLoai { get; set; }
        public int soLuotTruyCap {  get; set; }
        public int soChuong {  get; set; }
        public DateOnly ngayDangTai { get; set; }
        public DateOnly ngayCapNhap { get; set;}
    }
}
