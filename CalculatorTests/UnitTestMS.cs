using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using System.Linq;

namespace CalculatorTests
{
    /*
     * Tests the BasicMath, ComplexMath methods  
     *
     * 
    */
    
    [TestClass]
    public class UnitTestMS
    {

        /*
        [TestMethod]
        public void TestToArray()
        {
            string input = "(3+2 / 3)";
            ComplexMath cm = new ComplexMath();
            string[] ans = { "(","3", "+", "2", "/", "3",")" };
            string[] res = cm.Arraylize(input);
            Assert.IsTrue(Enumerable.SequenceEqual(res,ans));
        }
        */

        [TestMethod]
        public void TestAdd()
        {
            
            IComplexMath cm = new ComplexMath();
            float ans = 3 + 4;
            Assert.AreEqual(cm.Add(3, 4), ans);
        }

        [TestMethod]
        public void TestSubtract()
        {

            IComplexMath cm = new ComplexMath();
            float ans = 3 - 4;
            Assert.AreEqual(cm.Subtract(3, 4), ans);
        }

        [TestMethod]
        public void TestMultiply()
        {

            IComplexMath cm = new ComplexMath();
            float ans = 3 * 4;
            Assert.AreEqual(cm.Multiply(3, 4), ans);
        }

        [TestMethod]
        public void TestDivide()
        {

            IComplexMath cm = new ComplexMath();
            float ans = (float) 3 / 4;
            Assert.AreEqual(cm.Divide(3, 4), ans);
        }



        [TestMethod]
        public void TestExpressionWithSpace()
        {
            // Arrange
            string input = "3 + 4 * 2 ";
            IComplexMath cm = new ComplexMath();
            float ans = 3 + 4 * 2;
            // Act
            float res = cm.EvaluateExpression(input);

            // Assert
            Assert.AreEqual(res, ans);
        }

        [TestMethod]
        public void TestExpression()
        {
            // Arrange
            string input = "3+ 4*2 - 3/2 * 5";
            IComplexMath cm = new ComplexMath();
            float ans = 3 + 4 * 2 - (float) 3 /2 * 5;
            // Act
            float res = cm.EvaluateExpression(input);

            // Assert
            Assert.AreEqual(res, ans);
        }

        [TestMethod]
        public void TestExpression2()
        {
            // Arrange
            string input = "1+3-2+2";
            IComplexMath cm = new ComplexMath();
            float ans = 1+3-2+2;
            // Act
            float res = cm.EvaluateExpression(input);

            // Assert
            Assert.AreEqual(res, ans);
        }

        

        [TestMethod]
        public void TestExpressionWithParenthesis()
        {
            // Arrange
            string input = "1+3-(2+2)";
            IComplexMath cm = new MathGenious();
            float ans = 1 + 3 - (2 + 2);
            // Act
            float res = cm.EvaluateExpression(input);

            // Assert
            Assert.AreEqual(res, ans);
        }

        [TestMethod]
        public void TestExpressionWithParenthesis2()
        {
            // Arrange
            string input = "1+3-(2+2)*(3*2-2)";
            IComplexMath cm = new MathGenious();
            float ans = 1 + 3 - (2 + 2) * (3 * 2 - 2);
            // Act
            float res = cm.EvaluateExpression(input);

            // Assert
            Assert.AreEqual(res, ans);
        }

        [TestMethod]
        public void TestExpressionWithParenthesis3()
        {
            // Arrange
            string input = "(2+2)*(3-2)";
            IComplexMath cm = new MathGenious();
            float ans = (2 + 2) * (3 - 2);
            // Act
            float res = cm.EvaluateExpression(input);

            // Assert
            Assert.AreEqual(res, ans);
        }

        [TestMethod]
        public void TestExpressionWithParenthesis4()
        {
            // Arrange
            string input = "(3*2)*(3-2*1)";
            IComplexMath cm = new MathGenious();
            float ans = (3 * 2) * (3 - 2 * 1);
            // Act
            float res = cm.EvaluateExpression(input);

            // Assert
            Assert.AreEqual(res, ans);
        }

        


    }
}
