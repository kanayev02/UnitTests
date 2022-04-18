using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTestCalculation
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void Check_AgentTypeNonExist()
        {
            int rezult = -1;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(4, 32, 14);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_YongAgentTypeNonExist()
        {
            int rezult = -1;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(4, 21, 1);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_YongAgnetType1EasyTest()
        {
            int rezult = 4;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(1, 23, 2);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_YongAgnetType2EasyTest()
        {
            int rezult = 7;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(2, 23, 2);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_YongAgnetType3EasyTest()
        {
            int rezult = 9;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(3, 23, 2);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_AgentType1Exp12EasyTest()
        {
            int rezult = 28;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(1, 32, 12);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_AgentType2Exp21EasyTest()
        {
            int rezult = 82;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(2, 35, 21);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_AgentType3Exp40EasyTest()
        {
            int rezult = 200;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(3, 55, 40);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_AgentType1Exp45EasyTest()
        {
            int rezult = 122;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(1, 55, 45);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_AgentType2Exp16EasyTest()
        {
            int rezult = 59;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(2, 35, 16);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_YongAgnetType1HardTest()
        {
            int rezult = 3;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(1, (float)21.5, (float) 1.5);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_YongAgnetType3HardTest()
        {
            int rezult = 11;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(3, (float)21.5, (float)2.5);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_AgnetType1HardTest()
        {
            int rezult = 29;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(1, (float)33.7, (float)12.7);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_AgnetType2HardTest()
        {
            int rezult = 106;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(2, (float)45.7, (float)27.2);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_AgnetType3HardTest()
        {
            int rezult = 213;

            Calculation calc = new Calculation();
            int actual = calc.GetPriorityForAgent(3, (float)55.9, (float)42.6);

            Assert.AreEqual(rezult, actual);
        }

    }
}
