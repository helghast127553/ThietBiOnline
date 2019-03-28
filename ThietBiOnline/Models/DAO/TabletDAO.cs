using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.DTO;
using ThietBiOnline.Models.EF;

namespace ThietBiOnline.Models.DAO
{
    public static class TabletDAO
    {
        public static List<TabletDTO> GetTablets()
        {
            List<TabletDTO> tablets = null;
            using (var db = new ThietBiOnlineEntities())
            {
                tablets = (from tablet in db.Tablets.AsNoTracking()
                           orderby tablet.ID descending
                           select new TabletDTO
                           {
                               ID = tablet.ID,
                               TenSanPham = tablet.TenSanPham,
                               GiaSanPham = tablet.GiaSanPham,
                               SoLuong = tablet.SoLuong,
                               HinhAnhSanPham = tablet.HinhAnhSanPham,
                               IDLoaiSanPham = tablet.IDLoaiSanPham,
                               ManHinh = tablet.ManHinh,
                               CameraTruoc = tablet.CameraTruoc,
                               CameraSau = tablet.CameraSau,
                               CPU = tablet.CPU,
                               GPU = tablet.GPU,
                               RAM = tablet.RAM,
                               BoNhoTrong = tablet.BoNhoTrong,
                               Connection = tablet.Connection,
                               Pin = tablet.Pin,
                               HDH = tablet.HDH
                           }).Take(6).ToList();
            }
            return tablets;
        }
        public static Tablet GetSingleTablet(int ID)
        {
            Tablet tablet = null;
            using (var db = new ThietBiOnlineEntities())
            {
                tablet = db.Tablets.AsNoTracking().SingleOrDefault(x => x.ID == ID);
            }
            return tablet;
        }
        public static Tablet GetSingleTablet(int ID, string IDLoaiSanPham)
        {
            Tablet tablet = null;
            using (var db = new ThietBiOnlineEntities())
            {
                tablet = db.Tablets.AsNoTracking().SingleOrDefault(x => (x.ID == ID) && (x.IDLoaiSanPham == IDLoaiSanPham));
            }
            return tablet;
        }
        public static List<TabletDTO> GetAllTablet()
        {
            List<TabletDTO> tablets = null;
            using (var db = new ThietBiOnlineEntities())
            {
                tablets = db.Tablets.AsNoTracking()
                    .Select(x => new TabletDTO
                    {
                        ID = x.ID,
                        TenSanPham = x.TenSanPham,
                        GiaSanPham = x.GiaSanPham,
                        SoLuong = x.SoLuong,
                        HinhAnhSanPham = x.HinhAnhSanPham,
                        IDLoaiSanPham = x.IDLoaiSanPham,
                        ManHinh = x.ManHinh,
                        CameraTruoc = x.CameraTruoc,
                        CameraSau = x.CameraSau,
                        CPU = x.CPU,
                        GPU = x.GPU,
                        RAM = x.RAM,
                        BoNhoTrong = x.BoNhoTrong,
                        Connection = x.Connection,
                        Pin = x.Pin,
                        HDH = x.HDH
                    })
                    .ToList();
            }
            return tablets;
        }
        public static List<Tablet> GetAll()
        {
            List<Tablet> tablets = null;
            using (var db = new ThietBiOnlineEntities())
            {
                tablets = db.Tablets.OrderBy(x => x.ID).ToList();
            }
            return tablets;
        }
        public static bool InsertIntoTablet(Tablet tablet)
        {
            var result = false;
            using (var db = new ThietBiOnlineEntities())
            {
                db.Tablets.Add(tablet);
                result = db.SaveChanges() > 0 ? true : false;
            }
            return result;
        }
        public static bool UpdateIntoTablet(Tablet tablet)
        {
            var result = false;
            using (var db = new ThietBiOnlineEntities())
            {
                db.Entry(tablet).State = System.Data.Entity.EntityState.Modified;
                result = db.SaveChanges() > 0 ? true : false;
            }
            return result;
        }
        public static bool DeleteIntoTablet(int ID)
        {
            var result = false;
            using (var db = new ThietBiOnlineEntities())
            {
                var tablet = db.Tablets.SingleOrDefault(x => x.ID == ID);
                db.Tablets.Remove(tablet);
                result = db.SaveChanges() > 0 ? true : false;
            }
            return result;
        }
        public static List<Tablet> Search(string valueToFind)
        {
            List<Tablet> tablets = null;
            using (var db = new ThietBiOnlineEntities())
            {
                tablets = db.Tablets.Where(x => x.TenSanPham.Contains(valueToFind)).ToList();
            }
            return tablets;
        }
    }
}