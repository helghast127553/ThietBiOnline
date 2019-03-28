using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.EF;
using ThietBiOnline.Models.DTO;

namespace ThietBiOnline.Models.DAO
{
    public static class LaptopDAO
    {
        public static List<LaptopDTO> GetLaptops()
        {
            List<LaptopDTO> laptops = null;
            using (var db = new ThietBiOnlineEntities())
            {
                laptops = (from laptop in db.Laptops.AsNoTracking()
                           orderby laptop.ID descending
                           select new LaptopDTO
                           {
                               ID = laptop.ID,
                               TenSanPham = laptop.TenSanPham,
                               GiaSanPham = laptop.GiaSanPham,
                               SoLuong = laptop.SoLuong,
                               HinhAnhSanPham = laptop.HinhAnhSanPham,
                               IDLoaiSanPham = laptop.IDLoaiSanPham,
                               ManHinh = laptop.ManHinh,
                               CPU = laptop.CPU,
                               RAM = laptop.RAM,
                               VGA = laptop.VGA,
                               Connection = laptop.Connection,
                               HDH = laptop.HDH,
                               Nang = laptop.Nang
                           }).Take(6).ToList();
            }
            return laptops;
        }
        public static Laptop GetSingleLaptop(int ID)
        {
            Laptop laptop = null;
            using (var db = new ThietBiOnlineEntities())
            {
                laptop = db.Laptops.AsNoTracking().SingleOrDefault(x => x.ID == ID);
            }
            return laptop;
        }
        public static Laptop GetSingleLaptop(int ID, string IDLoaiSanPham)
        {
            Laptop laptop = null;
            using (var db = new ThietBiOnlineEntities())
            {
                laptop = db.Laptops.AsNoTracking().SingleOrDefault(x => (x.ID == ID) && (x.IDLoaiSanPham == IDLoaiSanPham));
            }
            return laptop;
        }
        public static List<LaptopDTO> GetALLaptops()
        {
            List<LaptopDTO> laptops = null;
            using (var db = new ThietBiOnlineEntities())
            {
                laptops = db.Laptops.AsNoTracking()
                    .Select(x => new LaptopDTO
                    {
                        ID = x.ID,
                        TenSanPham = x.TenSanPham,
                        GiaSanPham = x.GiaSanPham,
                        SoLuong = x.SoLuong,
                        HinhAnhSanPham = x.HinhAnhSanPham,
                        IDLoaiSanPham = x.IDLoaiSanPham,
                        ManHinh = x.ManHinh,
                        CPU = x.CPU,
                        RAM = x.RAM,
                        VGA = x.VGA,
                        Connection = x.Connection,
                        HDH = x.HDH,
                        Nang = x.Nang
                    })
                    .ToList();
            }
            return laptops;
        }
        public static List<Laptop> GetAll()
        {
            List<Laptop> laptops = null;
            using (var db = new ThietBiOnlineEntities())
            {
                laptops = db.Laptops.OrderBy(x => x.ID).ToList();
            }
            return laptops;
        }
        public static bool InsertIntoLaptop(Laptop laptop)
        {
            var result = false;
            using (var db = new ThietBiOnlineEntities())
            {
                db.Laptops.Add(laptop);
                result = db.SaveChanges() > 0 ? true : false;
            }
            return result;
        }
        public static bool UpdateIntoLaptop(Laptop laptop)
        {
            var result = false;
            using (var db = new ThietBiOnlineEntities())
            {
                db.Entry(laptop).State = System.Data.Entity.EntityState.Modified;
                result = db.SaveChanges() > 0 ? true : false;
            }
            return result;
        }
        public static bool DeleteIntoLaptop(int ID)
        {
            var result = false;
            using (var db = new ThietBiOnlineEntities())
            {
                var laptop = db.Laptops.SingleOrDefault(x => x.ID == ID);
                db.Laptops.Remove(laptop);
                result = db.SaveChanges() > 0 ? true : false;
            }
            return result;
        }
        public static List<Laptop> Search(string valueToFind)
        {
            List<Laptop> laptops = null;
            using (var db = new ThietBiOnlineEntities())
            {
                laptops = db.Laptops.Where(x => x.TenSanPham.Contains(valueToFind)).ToList();
            }
            return laptops;
        }
    }
}