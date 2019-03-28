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
    public class AdminPhoneController : Controller
    {
        // GET: Admin/AdminPhone
        public ActionResult Phone()
        {
            return View(PhoneBLL.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Phone phone, HttpPostedFileBase fileUpload)
        {
            var fileName = Path.GetFileName(fileUpload.FileName);
            var path = Path.Combine(Server.MapPath("~/Images"), fileName);
            if (System.IO.File.Exists(path))
            {
                ViewBag.ThongBao = "Hình ảnh đã tồn tại";
            }
            else
                fileUpload.SaveAs(path);
            phone.HinhAnhSanPham = fileUpload.FileName;
            PhoneBLL.InsertIntoPhone(phone);
            return RedirectToAction("Phone");
        }
        public ActionResult Edit(int ID)
        {
            return View(PhoneBLL.GetSinglePhone(ID));
        }
        [HttpPost]
        public ActionResult Edit(Phone phone)
        {
            PhoneBLL.UpdateIntoPhone(phone);
            return RedirectToAction("Phone");
        }
        public ActionResult Details(int ID)
        {
            return View(PhoneBLL.GetSinglePhone(ID));
        }
        [HttpPost]
        public JsonResult Delete(int ID)
        {
            PhoneBLL.DeleteIntoPhone(ID);
            return Json(ID, JsonRequestBehavior.AllowGet);
        }
    }
}