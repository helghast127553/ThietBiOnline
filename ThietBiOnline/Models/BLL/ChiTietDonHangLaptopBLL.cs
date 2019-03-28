using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.EF;
using ThietBiOnline.Models.DAO;

namespace ThietBiOnline.Models.BLL
{
    public class ChiTietDonHangLaptopBLL
    {
        public static int InsertIntoChiTietDonHangLaptop(ChiTietDonHangLaptop chiTietDonHangLaptop)
        {
            return ChiTietDonHangLaptopDAO.InsertIntoChiTietDonHangLaptop(chiTietDonHangLaptop);
        }
    }
}