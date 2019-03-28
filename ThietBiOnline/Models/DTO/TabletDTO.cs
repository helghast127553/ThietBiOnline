using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThietBiOnline.Models.DTO
{
    public class TabletDTO
    {
        public int ID { get; set; }
        public string TenSanPham { get; set; }
        public Nullable<int> GiaSanPham { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string HinhAnhSanPham { get; set; }
        public string MoTaSanPham { get; set; }
        public string IDLoaiSanPham { get; set; }
        public string ManHinh { get; set; }
        public string CameraTruoc { get; set; }
        public string CameraSau { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string BoNhoTrong { get; set; }
        public string Connection { get; set; }
        public string Pin { get; set; }
        public string HDH { get; set; }
    }
}