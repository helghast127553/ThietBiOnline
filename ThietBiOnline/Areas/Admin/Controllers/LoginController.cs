using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietBiOnline.Models.DTO;
using ThietBiOnline.Models.DAO;
using ThietBiOnline.Common;

namespace ThietBiOnline.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginViewModels login)
        {
            if (ModelState.IsValid)
            {
                var result = UserDAO.CheckUser(login.UserName, Encryptor.MD5Hash(login.Password));
                if (result == 1)
                {
                    var user = UserDAO.GetByID(login.UserName);
                    var userSession = new UserLogin();
                    userSession.UserID = user.ID;
                    userSession.UserName = user.UserName;
                    Session.Add(CommonConstants.UserSession, userSession);
                    return RedirectToAction("Laptop", "AdminLaptop");

                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại.");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng");
                }
            }
            return View("Index");
        }
    }
}