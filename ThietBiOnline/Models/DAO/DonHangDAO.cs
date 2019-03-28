using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.EF;

namespace ThietBiOnline.Models.DAO
{
    public class DonHangDAO
    {
        public static int InsertIntoDonHang(DonHang donHang)
        {
            var result = 0;
            using (var db = new ThietBiOnlineEntities())
            {
                db.DonHangs.Add(donHang);
                result = db.SaveChanges();
            }
            return result;
        }
        public static List<DonHang> GetALLDonHang()
        {
            List<DonHang> donHangs = null;
            using (var db = new ThietBiOnlineEntities())
            {
                donHangs = db.DonHangs.AsNoTracking().ToList();
            }
            return donHangs;
        }
        public static DonHang GetSingleDonHang(int ID)
        {
            DonHang donhang = null;
            using (var db = new ThietBiOnlineEntities())
            {
                donhang = db.DonHangs.AsNoTracking().SingleOrDefault(x => x.ID == ID);
            }
            return donhang;
        }
        public static bool UpdateIntoLDonHang(DonHang donhang)
        {
            var result = false;
            using (var db = new ThietBiOnlineEntities())
            {
                db.Entry(donhang).State = System.Data.Entity.EntityState.Modified;
                result = db.SaveChanges() > 0 ? true : false;
            }
            return result;
        }
    }
}