using Microsoft.VisualStudio.TestTools.UnitTesting;
using PavelMorozov;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMinMove_N21_K3_R5_O0()
        {
            int actual = PMath.MinMove(21, 1, 3, 0);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinMove_N22_K3_R6_O0()
        {
            int actual = PMath.MinMove(22, 1, 3, 0);
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinMove_N22_K4_R6_O0()
        {
            int actual = PMath.MinMove(22, 1, 4, 0);
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinMove_N23_K4_R6_O0()
        {
            int actual = PMath.MinMove(23, 1, 4, 0);
            int expected = 7;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinMove_N21_K4_R4_O4()
        {
            int actual = PMath.MinMove(21, 1, 4, 4);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinMove_N49_K12_R3_O3()
        {
            int actual = PMath.MinMove(49, 1, 12, 3);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinMove_N100_K11_R2_O9()
        {
            int actual = PMath.MinMove(100, 1, 11, 9);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinMove_N85_K7_R9_O5()
        {
            int actual = PMath.MinMove(85, 1, 7, 5);
            int expected = 9;
            Assert.AreEqual(expected, actual);
        }
    }
}