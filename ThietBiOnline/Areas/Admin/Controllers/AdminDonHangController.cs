using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietBiOnline.Models.BLL;
using ThietBiOnline.Models.EF;

namespace ThietBiOnline.Areas.Admin.Controllers
{
    public class AdminDonHangController : Controller
    {
        // GET: Admin/AdminDonHang
        public ActionResult DonHang()
        {
            return View(DonHangBLL.GetALLDonHang());
        }
        public ActionResult Edit(int ID)
        {
            return View(DonHangBLL.GetSingleDonHang(ID));
        }
        [HttpPost]
        public ActionResult Edit(DonHang donhang)
        {
            DonHangBLL.UpdateIntoLDonHang(donhang);
            return RedirectToAction("DonHang");
        }
        public ActionResult Details(int ID)
        {
            return View(DonHangBLL.GetSingleDonHang(ID));
        }
    }
}