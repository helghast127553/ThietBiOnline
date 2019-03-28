using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietBiOnline.Models.BLL;

namespace ThietBiOnline.Controllers
{
    public class LaptopController : Controller
    {
        // GET: Laptop
        public ActionResult Laptop()
        {
            return View(LaptopBLL.GetAllLaptops());
        }
    }
}