using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Yaji.Common;
using Yaji.DB;


namespace Yaji.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DevalayaService : IDevalayaService
    {

        public IList<DevalayaSummary> GetNewListings(int count)
        {

            DevalayaDB dvdb = new DevalayaDB();
            return dvdb.GetNewListings(count);
            

        }

        public DevalayaDetails GetDetails(Guid Id)
        {

            DevalayaDB dvdb = new DevalayaDB();
            return dvdb.GetDetails(Id);
            
        }
        
    }
}
