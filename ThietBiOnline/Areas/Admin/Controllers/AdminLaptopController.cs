using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using ThietBiOnline.Models.BLL;
using ThietBiOnline.Models.EF;

namespace ThietBiOnline.Areas.Admin.Controllers
{
    public class AdminLaptopController : BaseController
    {
        // GET: Admin/Admin
        public ActionResult Laptop()
        {
            return View(LaptopBLL.GetAll());
        }
        public ActionResult Create()
        {         
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Laptop laptop, HttpPostedFileBase fileUpload)
        {
            var fileName = Path.GetFileName(fileUpload.FileName);
            var path = Path.Combine(Server.MapPath("~/Images"), fileName);
            if (System.IO.File.Exists(path))
            {
                ViewBag.ThongBao = "Hình ảnh đã tồn tại";
            }
            else
                fileUpload.SaveAs(path);
            laptop.HinhAnhSanPham = fileUpload.FileName;
            LaptopBLL.InsertIntoLaptop(laptop);
            return RedirectToAction("Laptop");
        }
        public ActionResult Edit(int ID)
        {
            return View(LaptopBLL.GetSingleLaptop(ID));
        }
        [HttpPost]
        public ActionResult Edit(Laptop laptop)
        {
            LaptopBLL.UpdateIntoLaptop(laptop);
            return RedirectToAction("Laptop");
        }
        public ActionResult Details(int ID)
        {
            return View(LaptopBLL.GetSingleLaptop(ID));
        }
        [HttpPost]
        public JsonResult Delete(int ID)
        {
            LaptopBLL.DeleteIntoLaptop(ID);
            return Json(ID, JsonRequestBehavior.AllowGet);
        }

    }
}