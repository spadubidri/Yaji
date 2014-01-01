using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Yaji.UI.Areas.Account.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Account/Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signin(FormCollection data)
        {
            string userName = data["UserName"];
            string password = data["Password"];

            ActionResult result = null;
            result = new JsonResult();
            
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName);
            cookie.Value = "authenticated";
            Response.Cookies.Add(cookie);

            return result;
        }

    }
}
