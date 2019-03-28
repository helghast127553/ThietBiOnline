using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThietBiOnline.Common
{
    public static class CommonConstants
    {
        private static string USER_SESSION = "USER_SESSION";
        public static string UserSession
        {
            get
            {
                return USER_SESSION;
            }
            private set { }
        }
    }
}