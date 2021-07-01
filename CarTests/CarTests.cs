
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System.Collections.Generic;

namespace CarTestsNS
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, 0.00001);
        }
        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void gasTankLevelTest()
        {
            Car test_car1 = new Car("Alfa Romeo", "164 LS", 35, 17);
            Assert.AreEqual(35, test_car1.GasTankLevel, 0.001);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
         [TestMethod]
        public void OdometerTest()
        {
            Car test_car2 = new Car("Alfa Romeo", "164 LS", 35, 17);

            test_car2.Drive(595);

            Assert.AreEqual(595, test_car2.Odometer, 0.001);
        }
        [TestMethod]
        public void CarGasTankTest()
        {
            Car test_car3 = new Car("Alfa Romeo", "164 LS", 35, 17);
            test_car3.Drive(595);
            Assert.AreEqual(0, test_car3.GasTankLevel, 0.0001);
        }

        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        //TODO: can't have more gas than tank size, expect an exception

    }
}
