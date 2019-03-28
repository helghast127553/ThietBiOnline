using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThietBiOnline.Models.EF
{
    [MetadataTypeAttribute(typeof(LaptopMetDada))]
    public partial class Laptop
    {
        internal sealed class LaptopMetDada
        {
            [Display(Name = "Tên sản phẩm")]
            public string TenSanPham { get; set; }

            [Display(Name = "Giá sản phẩm")]
            public Nullable<int> GiaSanPham { get; set; }

            [Display(Name = "Số lượng")]
            public Nullable<int> SoLuong { get; set; }

            [Display(Name = "Hình ảnh sản phẩm")]
            public string HinhAnhSanPham { get; set; }

            [Display(Name = "Mô tả sản phẩm")]
            public string MoTaSanPham { get; set; }
            public string IDLoaiSanPham { get; set; }

            [Display(Name = "Màn hình")]
            public string ManHinh { get; set; }

            [Display(Name = "Ổ cứng")]
            public string HardDrive { get; set; }

            [Display(Name = "Card màn hình")]
            public string VGA { get; set; }

            [Display(Name = "Kết nối")]
            public string Connection { get; set; }

            [Display(Name = "Hệ điều hành")]
            public string HDH { get; set; }

            [Display(Name = "Nặng")]
            public Nullable<double> Nang { get; set; }
        }

    }
}