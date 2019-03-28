using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.EF;

namespace ThietBiOnline.Models.DAO
{
    public static class ChiTietDonHangTabletDAO
    {
        public static int InsertIntoChiTietDonHang(ChiTietDonHangTablet chiTietDonHangTablet)
        {
            var result = 0;
            using (var db = new ThietBiOnlineEntities())
            {
                db.ChiTietDonHangTablets.Add(chiTietDonHangTablet);
                result = db.SaveChanges();
            }
            return result;
        }
    }
}