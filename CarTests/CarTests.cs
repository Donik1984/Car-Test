
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System.Collections.Generic;

namespace CarTests
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
            Car test_car = new Car("Alfa Romeo", "164 LS", 10, 50);
            Assert.AreEqual(10, test_car.GasTankLevel, 0.001);
        }

        //TODO: gasTankLevel is accurate after driving within tank range
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        //TODO: can't have more gas than tank size, expect an exception

    }
}
