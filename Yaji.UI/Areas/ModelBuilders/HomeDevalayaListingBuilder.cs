using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yaji.Common;
using Yaji.Runtime;

namespace Yaji.UI
{
    public class HomeDevalayaListingBuilder
    {

        public static DevalayaSummaryListingModel Buid()
        {
            DevalayaServiceManager dvsvc = new DevalayaServiceManager();

            DevalayaSummaryListingModel model = new DevalayaSummaryListingModel();
            
            model.DevalayaListings = new List<DevalayaSummary>();
            foreach (DevalayaSummary dvSummary in dvsvc.GetNewListings(4))
            {
                model.DevalayaListings.Add(dvSummary);
            }
            return model;
        }
    }
}