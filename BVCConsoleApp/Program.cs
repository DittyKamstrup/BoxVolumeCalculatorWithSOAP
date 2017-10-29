using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVCConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BVCServiceReference1.Service1Client service = new BVCServiceReference1.Service1Client();

            var getSideResult = service.GetSide(10, 2, 2.5);

            var getVolumeResult = service.GetVolume(2, 2, 2);

            Console.WriteLine("1. resultat (forventet : 2) : " + getSideResult + ", 2. resultat (forventet: 8) : " + getVolumeResult);
        }
    }
}
