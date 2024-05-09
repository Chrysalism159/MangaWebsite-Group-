using System.ComponentModel.DataAnnotations;

namespace AnimeWebsite.Data
{
    public class DangKi
    {
        [Required(ErrorMessage = ("*")), MaxLength(32, ErrorMessage = ("Tối đa 32 kí tự")),
            Key]
        public string MaDK { get; set; }
        [Required(ErrorMessage = ("*"))]
        [DataType(DataType.Password)]
        public string? MatKhau { get; set; }
        [Required(ErrorMessage = ("*")), MaxLength(50, ErrorMessage = ("Tối đa 50 kí tự"))]
        public string HoTen { get; set; }

        public bool GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        public string? DiaChi { get; set; }

        [RegularExpression(@"0[983]\d{8}", ErrorMessage = "Số điện thoại không đúng")]
        public string? DienThoai { get; set; }

        [EmailAddress(ErrorMessage = ("Dữ liệu nhập vào không phải địa chỉ Email"))]
        public string Email { get; set; }

        public string? Hinh { get; set; } = null!;
    }
}
