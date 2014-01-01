using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaji.Common;
using System.Xml;


namespace Yaji.UI
{
    public class HomeModelBuilder
    {

        public static HomeModel Buid()
        {
            HomeModel model = new HomeModel();
            model.sliders = PopulateSliders();
            return model;

        }

        private static List<Slider> PopulateSliders()
        {
            List<Slider> sliders = new List<Slider>();

            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\subramanya_p1\documents\visual studio 2012\Projects\Yaji\Yaji.UI\Content\Slider\Slider.xml");
            foreach (XmlNode element in doc.FirstChild.ChildNodes)
            {
                
                Slider slider = new Slider();
                slider.contentdescription = element.Attributes["description"].Value;
                slider.heading = element.Attributes["heading"].Value;
                slider.sliderimage = element.Attributes["image"].Value;
                // call the service to get all the sliders. 
                sliders.Add(slider);
            }
            return sliders;
        }

    }
    
}
