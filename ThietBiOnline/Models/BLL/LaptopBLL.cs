using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.DTO;
using ThietBiOnline.Models.EF;
using ThietBiOnline.Models.DAO;

namespace ThietBiOnline.Models.BLL
{
    public static class LaptopBLL
    {
        public static List<LaptopDTO> GetLaptops()
        {
            return LaptopDAO.GetLaptops();
        }
        public static Laptop GetSingleLaptop(int ID)
        {
            return LaptopDAO.GetSingleLaptop(ID);
        }
        public static Laptop GetSingleLaptop(int ID, string IDLoaiSanPham)
        {
            return LaptopDAO.GetSingleLaptop(ID, IDLoaiSanPham);
        }
        public static List<LaptopDTO> GetAllLaptops()
        {
            return LaptopDAO.GetALLaptops();
        }
        public static List<Laptop> GetAll()
        {
            return LaptopDAO.GetAll();
        }
        public static bool InsertIntoLaptop(Laptop laptop)
        {
            return LaptopDAO.InsertIntoLaptop(laptop);
        }
        public static bool UpdateIntoLaptop(Laptop laptop)
        {
            return LaptopDAO.UpdateIntoLaptop(laptop);
        }
        public static bool DeleteIntoLaptop(int ID)
        {
            return LaptopDAO.DeleteIntoLaptop(ID);
        }
        public static List<Laptop> Search(string valueToFind)
        {
            return LaptopDAO.Search(valueToFind);
        }
    }
}