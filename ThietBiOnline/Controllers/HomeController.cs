using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietBiOnline.Models.BLL;

namespace ThietBiOnline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Laptops = LaptopBLL.GetLaptops();
            ViewBag.Phones = PhoneBLL.GetPhones();
            ViewBag.Tablets = TabletBLL.GetTablets();
            return View();
        }
    }
}