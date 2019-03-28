using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThietBiOnline.Models.EF
{
    [MetadataTypeAttribute(typeof(DonHangMetaData))]
    public partial class DonHang
    {
        internal sealed class DonHangMetaData
        {
            [Display(Name = "Tên khách hàng")]
            public string TenKhachHang { get; set; }

            [Display(Name = "Tên nhân viên")]
            public string TenNhanVien { get; set; }

            [Display(Name = "Số điện thoại")]
            public string SDT { get; set; }

            [Display(Name = "Ngày mua")]
            public Nullable<System.DateTime> NgayMua { get; set; }
            public string Email { get; set; }
        }
    }
}