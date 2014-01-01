using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaji.Common;

namespace Yaji.Runtime
{
    public class DevalayaServiceManager :  IDevalayaServiceManager 
    {

        public IList<DevalayaSummary> GetNewListings(int count)
        {
            try
            {
                DevalayaService.DevalayaServiceClient serviceClient = new DevalayaService.DevalayaServiceClient();
                return serviceClient.GetNewListings(count);
            }
            catch (Exception ex)
            {
                // log the exception 
                return null;
            }
            
        }


        public DevalayaDetails GetDetails(Guid Id)
        {
            try
            {
                DevalayaService.DevalayaServiceClient serviceClient = new DevalayaService.DevalayaServiceClient();
                return serviceClient.GetDetails(Id);
            }
            catch (Exception ex)
            {
                // log the exception 
                return null;
            }

        }
    }
}
