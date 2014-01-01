using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yaji.UI.Controllers
{
    public class SuggestController : Controller
    {
        //
        // GET: /Suggest/

        [Authorize]
        public ActionResult Index()
        {



            return View();
        }

    }
}
