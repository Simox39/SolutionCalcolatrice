using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCalc;

namespace LibraryCalc.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSomma()
        {
            double num1 = 7;
            double num2 = 2;
            double ris = 9;
            double somma = Calc.Somma(num1, num2);
            Assert.AreEqual(ris, somma);
        }
        [TestMethod]
        public void TestSommaPerZero()
        {
            double num1 = 0;
            double num2 = 1;
            double ris = 1;
            double somma = Calc.Somma(num1, num2);
            Assert.AreEqual(ris, somma);
        }
        [TestMethod]
        public void TestSommaPerDueZeri()
        {
            double num1 = 0;
            double num2 = 0;
            double ris = 0;
            double somma = Calc.Somma(num1, num2);
            Assert.AreEqual(ris, somma);
        }
        [TestMethod]
        public void TestSommaPerCinque()
        {
            double num1 = 5;
            double num2 = 0;
            double ris = 5;
            double somma = Calc.Somma(num1, num2);
            Assert.AreEqual(ris, somma);
        }
    }
}
