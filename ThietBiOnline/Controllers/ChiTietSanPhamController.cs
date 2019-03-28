using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietBiOnline.Models.BLL;

namespace ThietBiOnline.Controllers
{
    public class ChiTietSanPhamController : Controller
    {
        // GET: ChiTietSanPham
        public ViewResult ChiTietLaptop(int ID)
        {
            var laptop = LaptopBLL.GetSingleLaptop(ID);
            if (laptop == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(laptop);
        }      
        public ViewResult ChiTietPhone(int ID)
        {
            var phone = PhoneBLL.GetSinglePhone(ID);
            if (phone == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(phone);
        }
        public ViewResult ChiTietTablet(int ID)
        {
            var tablet = TabletBLL.GetSingleTablet(ID);
            if (tablet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(tablet);
        }
    }
}