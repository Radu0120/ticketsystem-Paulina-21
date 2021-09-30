using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StoreBaeltTests
    {
        [TestMethod()]
        public void StoreBaeltTest_Weekend()
        {
            Vehicle v=new Car();
            v.Brobizz = false;
            v.Date=DateTime.Parse("2021-09-26");
            double expected = 240;

            expected *= 0.8;

            

            StoreBaelt s = new StoreBaelt();
        

            Assert.AreEqual(expected,s.CarDiscountedPrice(v));
        }
        [TestMethod()]
        public void StoreBaeltTest_NotWeekend()
        {
            Vehicle v = new Car();
            v.Brobizz = false;
            v.Date = DateTime.Parse("2021-09-27");
            double expected = 240;



            StoreBaelt s = new StoreBaelt();


            Assert.AreEqual(expected, s.CarDiscountedPrice(v));
        }
    }
}