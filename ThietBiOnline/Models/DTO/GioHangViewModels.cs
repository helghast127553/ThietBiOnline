using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.BLL;
using ThietBiOnline.Models.EF;

namespace ThietBiOnline.Models.DTO
{
    public class GioHangViewModels
    {
        public GioHangViewModels(int ID, string IDLoaiSanPham)
        {
            this.ID = ID;
            this.IDLoaiSanPham = IDLoaiSanPham;
            if (IDLoaiSanPham == "Phone")
            {
                Phone phone = PhoneBLL.GetSinglePhone(ID, IDLoaiSanPham);
                TenSanPham = phone.TenSanPham;
                HinhAnh = phone.HinhAnhSanPham;
                DonGia = phone.GiaSanPham;
            }
            else if (IDLoaiSanPham == "Laptop")
            {
                Laptop laptop = LaptopBLL.GetSingleLaptop(ID, IDLoaiSanPham);
                TenSanPham = laptop.TenSanPham;
                HinhAnh = laptop.HinhAnhSanPham;
                DonGia = laptop.GiaSanPham;
            }
            else
            {
                Tablet tablet = TabletBLL.GetSingleTablet(ID, IDLoaiSanPham);
                TenSanPham = tablet.TenSanPham;
                HinhAnh = tablet.HinhAnhSanPham;
                DonGia = tablet.GiaSanPham;
            }
        }
        public int ID { get; set; }
        public Nullable<int> MaDonHang { get; set; }
        public string IDLoaiSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<int> DonGia { get; set; }
        public Nullable<int> SoLuong { get; set; } = 1;
        public Nullable<int> ThanhTien
        {
            get { return DonGia * SoLuong; }
        }
        public string Cocatenate
        {
            get { return ID.ToString() + IDLoaiSanPham; }
        }
    }
}