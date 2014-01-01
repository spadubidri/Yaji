using System;
using System.Runtime.Serialization;

namespace Yaji.Common
{
    [DataContract(Name = "DevalayaDetails")]
    [Serializable]
    public class DevalayaDetails
    {
        [DataMember]
        public Guid ID;

        [DataMember]
        public string Name;

        [DataMember]
        public string ShortDescription;

        [DataMember]
        public string Description;


        [DataMember]
        public string TimingDetails;

        [DataMember]
        public string MapLocation;

        [DataMember]
        public string SevaDetails;

        [DataMember]
        public string SpecialOccasions;

        [DataMember]
        public string HowToreach;

        [DataMember]
        public string Contact;

        [DataMember]
        public long NoOfFollowers;

        [DataMember]
        public string ThumbnailImg;
    }
}
