using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThietBiOnline.Models.DTO
{
    public class LoginViewModels
    {
        [Required(ErrorMessage = "Mời nhập user name")]
        public string UserName{ get; set; }

        [Required(ErrorMessage = "Mời nhập mật khẩu")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}