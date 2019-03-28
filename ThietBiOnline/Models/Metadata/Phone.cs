using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThietBiOnline.Models.EF
{
    [MetadataTypeAttribute(typeof(PhoneMetaData))]
    public partial class Phone
    {
        internal sealed class PhoneMetaData
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

            [Display(Name = "Màn hình")]
            public string ManHinh { get; set; }

            [Display(Name = "Camera trước")]
            public string CameraTruoc { get; set; }

            [Display(Name = "Camera sau")]
            public string CameraSau { get; set; }

            [Display(Name = "Bộ nhớ trong")]
            public string BoNhoTrong { get; set; }

            [Display(Name = "Hệ điều hành")]
            public string HDH { get; set; }
        }
    }
}