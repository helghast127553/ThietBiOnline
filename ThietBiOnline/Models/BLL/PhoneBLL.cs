using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.DTO;
using ThietBiOnline.Models.EF;
using ThietBiOnline.Models.DAO;

namespace ThietBiOnline.Models.BLL
{
    public static class PhoneBLL
    {
        public static List<PhoneDTO> GetPhones()
        {
            return PhoneDAO.GetPhones();
        }
        public static Phone GetSinglePhone(int ID)
        {
            return PhoneDAO.GetSinglePhone(ID);
        }
        public static Phone GetSinglePhone(int ID, string IDLoaiSanPham)
        {
            return PhoneDAO.GetSinglePhone(ID, IDLoaiSanPham);
        }
        public static List<PhoneDTO> GetAllPhone()
        {
            return PhoneDAO.GetALLPhone();
        }
        public static List<Phone> GetAll()
        {
            return PhoneDAO.GetAll();
        }
        public static bool InsertIntoPhone(Phone phone)
        {
            return PhoneDAO.InsertIntoPhone(phone);
        }
        public static bool UpdateIntoPhone(Phone phone)
        {
            return PhoneDAO.UpdateIntoPhone(phone);
        }
        public static bool DeleteIntoPhone(int ID)
        {
            return PhoneDAO.DeleteIntoPhone(ID);
        }
        public static List<Phone> Search(string valueToFind)
        {
            return PhoneDAO.Search(valueToFind);
        }
    }
}