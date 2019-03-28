using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.EF;
using ThietBiOnline.Models.DAO;

namespace ThietBiOnline.Models.BLL
{
    public static class DonHangBLL
    {
        public static int InsertIntoDonHang(DonHang donHang)
        {
            return DonHangDAO.InsertIntoDonHang(donHang);
        }
        public static List<DonHang> GetALLDonHang()
        {
            return DonHangDAO.GetALLDonHang();
        }
        public static DonHang GetSingleDonHang(int ID)
        {
            return DonHangDAO.GetSingleDonHang(ID);
        }
        public static bool UpdateIntoLDonHang(DonHang donhang)
        {
            return DonHangDAO.UpdateIntoLDonHang(donhang);
        }
    }
}