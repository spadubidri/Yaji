using System;
using System.Runtime.Serialization;

namespace Yaji.Common
{
    [DataContract(Name = "DevalayaSummary")]
    [Serializable]
    public class DevalayaSummary
    {
        [DataMember]
        public Guid ID;

        [DataMember]
        public string Name;

        [DataMember]
        public string ShortDescription;

        [DataMember]
        public string ThumbNailImage;

        [DataMember]
        public long NoOfFollowers;

    }
}
