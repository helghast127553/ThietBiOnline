using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.EF;

namespace ThietBiOnline.Models.DAO
{
    public static class ChiTietDonHangLaptopDAO
    {
        public static int InsertIntoChiTietDonHangLaptop(ChiTietDonHangLaptop chiTietDonHangLaptop)
        {
            var result = 0;
            using (var db = new ThietBiOnlineEntities())
            {
                db.ChiTietDonHangLaptops.Add(chiTietDonHangLaptop);
                result = db.SaveChanges();
            }
            return result;
        }
    }
}