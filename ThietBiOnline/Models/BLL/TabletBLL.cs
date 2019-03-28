using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.DTO;
using ThietBiOnline.Models.EF;
using ThietBiOnline.Models.DAO;

namespace ThietBiOnline.Models.BLL
{
    public static class TabletBLL
    {
        public static List<TabletDTO> GetTablets()
        {
            return TabletDAO.GetTablets();
        }
        public static Tablet GetSingleTablet(int ID)
        {
            return TabletDAO.GetSingleTablet(ID);
        }
        public static Tablet GetSingleTablet(int ID, string IDLoaiSanPham)
        {
            return TabletDAO.GetSingleTablet(ID, IDLoaiSanPham);
        }
        public static List<TabletDTO> GetAllTablet()
        {
            return TabletDAO.GetAllTablet();
        }
        public static List<Tablet> GetAll()
        {
            return TabletDAO.GetAll();
        }
        public static bool InsertIntoTablet(Tablet tablet)
        {
            return TabletDAO.InsertIntoTablet(tablet);
        }
        public static bool UpdateIntoTablet(Tablet tablet)
        {
            return TabletDAO.UpdateIntoTablet(tablet);
        }
        public static bool DeleteIntoTablet(int ID)
        {
            return TabletDAO.DeleteIntoTablet(ID);
        }
        public static List<Tablet> Search(string valueToFind)
        {
            return TabletDAO.Search(valueToFind);
        }
    }
}