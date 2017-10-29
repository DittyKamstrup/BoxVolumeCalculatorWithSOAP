using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoxVolumeCalculatorWithSOAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxVolumeCalculatorWithSOAP.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetSideTest()
        {
            //Arrange
            Service1 service = new Service1();
            //Act
            var result = service.GetSide(10, 2.5, 2);
            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void GetVolumeTest()
        {
            //Arrange
            Service1 service = new Service1();
            //Act
            var result = service.GetVolume(2, 2, 2);
            //Assert
            Assert.AreEqual(8, result);
        }
    }
}