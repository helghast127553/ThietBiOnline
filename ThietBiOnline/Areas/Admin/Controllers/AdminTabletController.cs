using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietBiOnline.Models.BLL;
using ThietBiOnline.Models.EF;

namespace ThietBiOnline.Areas.Admin.Controllers
{
    public class AdminTabletController : Controller
    {
        // GET: Admin/AdminTablet
        public ActionResult Tablet()
        {
            return View(TabletBLL.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Tablet tablet, HttpPostedFileBase fileUpload)
        {
            var fileName = Path.GetFileName(fileUpload.FileName);
            var path = Path.Combine(Server.MapPath("~/Images"), fileName);
            if (System.IO.File.Exists(path))
            {
                ViewBag.ThongBao = "Hình ảnh đã tồn tại";
            }
            else
                fileUpload.SaveAs(path);
            tablet.HinhAnhSanPham = fileUpload.FileName;
            TabletBLL.InsertIntoTablet(tablet);
            return RedirectToAction("Tablet");
        }
        public ActionResult Edit(int ID)
        {
            return View(TabletBLL.GetSingleTablet(ID));
        }
        [HttpPost]
        public ActionResult Edit(Tablet tablet)
        {
            TabletBLL.UpdateIntoTablet(tablet);
            return RedirectToAction("Tablet");
        }
        public ActionResult Details(int ID)
        {
            return View(TabletBLL.GetSingleTablet(ID));
        }
        [HttpPost]
        public JsonResult Delete(int ID)
        {
            TabletBLL.DeleteIntoTablet(ID);
            return Json(ID, JsonRequestBehavior.AllowGet);
        }
    }
}