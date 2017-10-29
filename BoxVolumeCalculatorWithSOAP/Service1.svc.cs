using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BoxVolumeCalculatorWithSOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double GetSide(double volume, double side1, double side2)
        {
            double length = volume / (side1 * side2);
            return length;
        }

        public double GetVolume(double length, double width, double height)
        {
            double volume = length * width * height;
            return volume;
        }
    }
}
