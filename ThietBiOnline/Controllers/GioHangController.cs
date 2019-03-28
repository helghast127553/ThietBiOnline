using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietBiOnline.Models.BLL;
using ThietBiOnline.Models.DTO;
using ThietBiOnline.Models.EF;

namespace ThietBiOnline.Controllers
{
    public class GioHangController : Controller
    {
        public List<GioHangViewModels> GetGioHang()
        {
            var GioHangs = Session["GioHang"] as List<GioHangViewModels>;
            if (GioHangs == null)
            {
                GioHangs = new List<GioHangViewModels>();
                Session["GioHang"] = GioHangs;
            }
            return GioHangs;
        }

        public ActionResult AddGioHang(int ID, string IDLoaiSanPham, string strUrl)
        {
            var GioHangs = GetGioHang();
            var sanPham = GioHangs.Find(x => (x.ID == ID) && (x.IDLoaiSanPham == IDLoaiSanPham));
            if (sanPham == null)
            {
                GioHangs.Add(new GioHangViewModels(ID, IDLoaiSanPham));
                return Redirect(strUrl);
            }
            else
            {
                sanPham.SoLuong++;
                return Redirect(strUrl);
            }
        }

        [HttpPost]
        public JsonResult UpdateGioHang(int ID, string IDLoaiSanPham, int soLuong)
        {
            var GioHangs = Session["GioHang"] as List<GioHangViewModels>;
            var sanPham = GioHangs.Find(x => (x.ID == ID) && (x.IDLoaiSanPham == IDLoaiSanPham));
            if (sanPham != null)
                sanPham.SoLuong = soLuong;
            return Json(new
            {
                ThanhTien = String.Format("{0:0,0} VND", sanPham.ThanhTien),
                TongTien = String.Format("{0:0,0} VND", SumTotalAmount())
            },
                JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DeleteGioHang(int ID, string IDLoaiSanPham)
        {
            var GioHangs = Session["GioHang"] as List<GioHangViewModels>;
            GioHangs.RemoveAll(x => (x.ID == ID) && (x.IDLoaiSanPham == IDLoaiSanPham));
            if (GioHangs.Count == 0)
                return RedirectToAction("Index", "Home");
            return RedirectToAction("GioHang");
        }

        public ActionResult GioHang()
        {
            if (Session["GioHang"] == null)
                return RedirectToAction("Index", "Home");
            ViewBag.gioHangs = Session["GioHang"] as List<GioHangViewModels>;
            ViewBag.sumTotalAmount = SumTotalAmount();
            return View();
        }

        public int? SumTotalAmount()
        {
            var GioHangs = Session["GioHang"] as List<GioHangViewModels>;
            int? sum = 0;
            if (GioHangs != null)
            {
                sum = GioHangs.Sum(x => x.ThanhTien);
            }
            return sum;
        }

        public int CountTotalAmount()
        {
            var GioHangs = Session["GioHang"] as List<GioHangViewModels>;
            int count = 0;
            if (GioHangs != null)
                count = GioHangs.Count();
            return count;
        }

        public PartialViewResult GioHangPartial()
        {
            return PartialView(CountTotalAmount());
        }

        public PartialViewResult DonHangPartial()
        {
            return PartialView("GioHangPartial");
        }

        [HttpPost]
        public ActionResult OrderProduct(DonHangViewModels model)
        {
            if (ModelState.IsValid)
            {
                var donHang = new DonHang
                {
                    TenKhachHang = model.TenKhachHang,
                    TenNhanVien = model.TenNhanVien,
                    SDT = model.SDT,
                    Email = model.Email,
                };
                DonHangBLL.InsertIntoDonHang(donHang);

                var gioHangs = Session["GioHang"] as List<GioHangViewModels>;
                for (int i = 0; i < gioHangs.Count; i++)
                {
                    if (gioHangs[i].IDLoaiSanPham == "Phone")
                    {
                        ChiTietDonHangPhoneBLL.InsertIntoChiTietDonHangPhone(new ChiTietDonHangPhone
                        {
                            
                            MaDonHang = donHang.ID,
                            MaSanPham = gioHangs[i].ID,
                            TenSanPham = gioHangs[i].TenSanPham,
                            DonGia = gioHangs[i].DonGia,
                            ThanhTien = gioHangs[i].ThanhTien,
                            SoLuong = gioHangs[i].SoLuong
                        });                        
                    }
                    else if (gioHangs[i].IDLoaiSanPham == "Laptop")
                    {
                        ChiTietDonHangLaptopBLL.InsertIntoChiTietDonHangLaptop(new ChiTietDonHangLaptop
                        {
                            MaDonHang = donHang.ID,
                            MaSanPham = gioHangs[i].ID,
                            TenSanPham = gioHangs[i].TenSanPham,
                            DonGia = gioHangs[i].DonGia,
                            ThanhTien = gioHangs[i].ThanhTien,
                            SoLuong = gioHangs[i].SoLuong
                        });
                    }
                    else
                    {
                        ChiTietDonHangTabletBLL.InsertIntoChiTietDonHangTablet(new ChiTietDonHangTablet
                        {
                            MaDonHang = donHang.ID,
                            MaSanPham = gioHangs[i].ID,
                            TenSanPham = gioHangs[i].TenSanPham,
                            DonGia = gioHangs[i].DonGia,
                            ThanhTien = gioHangs[i].ThanhTien,
                            SoLuong = gioHangs[i].SoLuong
                        });
                    }                    
                }
                Session.Clear();
                return RedirectToAction("Index", "Home");
            }
            if (Session["GioHang"] == null)
                return RedirectToAction("Index", "Home");
            ViewBag.gioHangs = Session["GioHang"] as List<GioHangViewModels>;
            ViewBag.sumTotalAmount = SumTotalAmount();
            return View("GioHang");
        }
    }
}