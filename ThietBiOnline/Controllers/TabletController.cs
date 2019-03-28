using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietBiOnline.Models.BLL;

namespace ThietBiOnline.Controllers
{
    public class TabletController : Controller
    {
        // GET: Tablet
        public ActionResult Tablet()
        {
            return View(TabletBLL.GetAllTablet());
        }
    }
}