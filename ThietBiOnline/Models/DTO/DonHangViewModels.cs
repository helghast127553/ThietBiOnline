using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThietBiOnline.Models.DTO
{
    public class DonHangViewModels
    {
        public int ID { get; set; }

        [Display(Name = "Họ và tên khách hàng")]
        [Required(ErrorMessage = "{0} không được để trống")]
        public string TenKhachHang { get; set; }

        [Display(Name = "Họ và tên nhân viên")]
        [Required(ErrorMessage = "{0} không được để trống")]
        public string TenNhanVien { get; set; }


        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "{0} không được để trống")]
        [Phone(ErrorMessage = "Số điện thoại phải nhập đúng")]
        [RegularExpression(@"^([0-9]{10,11})$",
            ErrorMessage = "Số điện thoại phải từ 10 tới 11 số")]
        public string SDT { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email phải nhập đúng")]
        public string Email { get; set; }
    }
}