using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaji.Common
{
    public interface IDevalayaServiceManager
    {
        IList<DevalayaSummary> GetNewListings(int count);

    }
}
