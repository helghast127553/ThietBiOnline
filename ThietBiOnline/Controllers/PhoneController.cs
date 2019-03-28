using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietBiOnline.Models.BLL;

namespace ThietBiOnline.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Phone()
        {
            return View(PhoneBLL.GetAllPhone());
        }
    }
}