using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.EF;
using ThietBiOnline.Models.DAO;

namespace ThietBiOnline.Models.BLL
{
    public static class ChiTietDonHangTabletBLL
    {
        public static int InsertIntoChiTietDonHangTablet(ChiTietDonHangTablet chiTietDonHangTablet)
        {
            return ChiTietDonHangTabletDAO.InsertIntoChiTietDonHang(chiTietDonHangTablet);
        }
    }
}