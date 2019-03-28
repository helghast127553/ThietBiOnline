using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.EF;

namespace ThietBiOnline.Models.DAO
{
    public static class ChiTietDonHangPhoneDAO
    {
        public static int InsertIntoChiTietDonHangPhone(ChiTietDonHangPhone chiTietDonHangPhone)
        {
            var result = 0;
            using (var db = new ThietBiOnlineEntities())
            {
                db.ChiTietDonHangPhones.Add(chiTietDonHangPhone);
                result = db.SaveChanges();
            }
            return result;
        }
    }
}