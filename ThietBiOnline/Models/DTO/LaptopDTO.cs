using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThietBiOnline.Models.DTO
{
    public class LaptopDTO
    {
        public int ID { get; set; }
        public string TenSanPham { get; set; }
        public Nullable<int> GiaSanPham { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string HinhAnhSanPham { get; set; }
        public string MoTaSanPham { get; set; }
        public string IDLoaiSanPham { get; set; }
        public string ManHinh { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string HardDrive { get; set; }
        public string VGA { get; set; }
        public string Connection { get; set; }
        public string HDH { get; set; }
        public Nullable<double> Nang { get; set; }
    }
}