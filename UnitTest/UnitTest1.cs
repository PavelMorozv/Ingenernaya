using Microsoft.VisualStudio.TestTools.UnitTesting;
using PavelMorozov;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMinMove_N21_K3_R5()
        {
            int actual = PMath.MinMove(21, 1, 3);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinMove_N22_K3_R6()
        {
            int actual = PMath.MinMove(22, 1, 3);
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinMove_N22_K4_R6()
        {
            int actual = PMath.MinMove(22, 1, 4);
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinMove_N23_K4_R6()
        {
            int actual = PMath.MinMove(23, 1, 4);
            int expected = 7;
            Assert.AreEqual(expected, actual);
        }
    }
}