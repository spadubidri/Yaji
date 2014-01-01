using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yaji.Common;
using Yaji.Runtime;
namespace Yaji.UI.Areas.Devalaya.Controllers
{
    public class DevalayaController : Controller
    {
        //
        // GET: /Devalaya/Devalaya/

        public ActionResult Index()
        {
            return View(HomeModelBuilder.Buid());
        }

        public ActionResult NewDevalayaListings()
        {
            return View(HomeDevalayaListingBuilder.Buid());
        }

        public ActionResult EventsListings()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ViewDetail(string ID)
        {

            DevalayaServiceManager dvsvc = new DevalayaServiceManager();
            DevalayaDetails details = dvsvc.GetDetails(new Guid(ID));

            DevalayaListingModel model = new DevalayaListingModel();
            model.Description = details.Description;
            model.ID = details.ID;
            model.ShortDescription = details.ShortDescription;
            model.Name = details.Name;
            model.ThumbNailImg = details.ThumbnailImg;
            model.NoOfFollowers = details.NoOfFollowers;
            model.SevaDetails = details.SevaDetails;
            model.SpecialOccasions = details.SpecialOccasions;
            model.Timings = details.TimingDetails;
            model.Location = details.MapLocation;
            model.Contact = details.Contact;
            model.HowToReach = details.HowToreach;
            return View(model);

        }

    }
}
