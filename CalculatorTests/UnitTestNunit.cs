using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Test;

namespace CalculatorTests
{
    /// <summary>
    /// Summary description for UnitTestNunit
    /// </summary>
    [TestFixture]
    public class UnitTestNunit
    {
        [Test]
        public void TestFail()
        {
            Assert.That(12, Is.EqualTo(11));

        }

        [Test]
        public void Test1()
        {
            string input= "3+4*2";
            IComplexMath test = new ComplexMath();
            Assert.AreEqual(test.EvaluateExpression(input), 11);
            
        }
    }
}
