using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.DTO;
using ThietBiOnline.Models.EF;

namespace ThietBiOnline.Models.DAO
{
    public static class PhoneDAO
    {
        public static List<PhoneDTO> GetPhones()
        {
            List<PhoneDTO> phones = null;
            using (var db = new ThietBiOnlineEntities())
            {
                phones = (from phone in db.Phones.AsNoTracking()
                          orderby phone.ID descending
                          select new PhoneDTO
                          {
                              ID = phone.ID,
                              TenSanPham = phone.TenSanPham,
                              GiaSanPham = phone.GiaSanPham,
                              SoLuong = phone.SoLuong,
                              HinhAnhSanPham = phone.HinhAnhSanPham,
                              IDLoaiSanPham = phone.IDLoaiSanPham,
                              ManHinh = phone.ManHinh,
                              CameraTruoc = phone.CameraTruoc,
                              CameraSau = phone.CameraSau,
                              RAM = phone.RAM,
                              BoNhoTrong = phone.BoNhoTrong,
                              CPU = phone.CPU,
                              GPU = phone.GPU,
                              Pin = phone.Pin,
                              HDH = phone.HDH
                          }).Take(6).ToList();
            }
            return phones;
        }
        public static Phone GetSinglePhone(int ID)
        {
            Phone phone = null;
            using (var db = new ThietBiOnlineEntities())
            {
                phone = db.Phones.AsNoTracking().SingleOrDefault(x => x.ID == ID);
            }
            return phone;
        }
        public static Phone GetSinglePhone(int ID, string IDLoaiSanPham)
        {
            Phone phone = null;
            using (var db = new ThietBiOnlineEntities())
            {
                phone = db.Phones.AsNoTracking().SingleOrDefault(x => (x.ID == ID)
                && (x.IDLoaiSanPham == IDLoaiSanPham));
            }
            return phone;
        }
        public static List<PhoneDTO> GetALLPhone()
        {
            List<PhoneDTO> phones = null;
            using (var db = new ThietBiOnlineEntities())
            {
                phones = db.Phones.AsNoTracking()
                     .Select(x => new PhoneDTO
                     {
                         ID = x.ID,
                         TenSanPham = x.TenSanPham,
                         GiaSanPham = x.GiaSanPham,
                         SoLuong = x.SoLuong,
                         HinhAnhSanPham = x.HinhAnhSanPham,
                         IDLoaiSanPham = x.IDLoaiSanPham,
                         ManHinh = x.ManHinh,
                         CameraTruoc = x.CameraTruoc,
                         CameraSau = x.CameraSau,
                         RAM = x.RAM,
                         BoNhoTrong = x.BoNhoTrong,
                         CPU = x.CPU,
                         GPU = x.GPU,
                         Pin = x.Pin,
                         HDH = x.HDH
                     })
                     .ToList();
            }
            return phones;
        }
        public static List<Phone> GetAll()
        {
            List<Phone> phones = null;
            using (var db = new ThietBiOnlineEntities())
            {
                phones = db.Phones.OrderBy(x => x.ID).ToList();
            }
            return phones;
        }
        public static bool InsertIntoPhone(Phone phone)
        {
            var result = false;
            using (var db = new ThietBiOnlineEntities())
            {
                db.Phones.Add(phone);
                result = db.SaveChanges() > 0 ? true : false;
            }
            return result;
        }
        public static bool UpdateIntoPhone(Phone phone)
        {
            var result = false;
            using (var db = new ThietBiOnlineEntities())
            {
                db.Entry(phone).State = System.Data.Entity.EntityState.Modified;
                result = db.SaveChanges() > 0 ? true : false;
            }
            return result;
        }
        public static bool DeleteIntoPhone(int ID)
        {
            var result = false;
            using (var db = new ThietBiOnlineEntities())
            {
                var phone = db.Phones.SingleOrDefault(x => x.ID == ID);
                db.Phones.Remove(phone);
                result = db.SaveChanges() > 0 ? true : false;
            }
            return result;
        }
        public static List<Phone> Search(string valueToFind)
        {
            List<Phone> phones = null;
            using (var db = new ThietBiOnlineEntities())
            {
                phones = db.Phones.Where(x => x.TenSanPham.Contains(valueToFind)).ToList();
            }
            return phones;
        }
    }
}