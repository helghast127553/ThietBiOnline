using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietBiOnline.Models.BLL;
using ThietBiOnline.Models.DTO;

namespace ThietBiOnline.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        [HttpPost]
        public ActionResult SearchResults(FormCollection data)
        {
            var laptops = LaptopBLL.Search(data["search"].ToString());
            var phones = PhoneBLL.Search(data["search"].ToString());
            var tablets = TabletBLL.Search(data["search"].ToString());
            if (laptops.Count == 0 && phones.Count == 0 & tablets.Count == 0)
            {
                ViewBag.Message = "Không tìm thấy sản phẩm nào";
            }
            var products = new ProductViewModels();
            products.Laptops = laptops;
            products.Phones = phones;
            products.Tablets = tablets;
            return View(products);
        }
    }
}