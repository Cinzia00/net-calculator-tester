using net_calculator_tester;
using System.Security.Cryptography.X509Certificates;

namespace TesterCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTest()
        {
            // Initialize
            float num1 = 5;
            float num2 = 4;
            Calculator calculateSum = new Calculator();
            float expectedResult = 9;

            //Act
            float realResult = calculateSum.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, realResult);

        }
        [Test]
        public void SubstractTest()
        {

            // Initialize
            Calculator calculateSubstract = new Calculator();
            float num11 = 2;
            float num12 = 4;
            float numeroAtteso = -2;

            //Act
            float realResult = calculateSubstract.Substract(num11, num12);

            // Assert
            Assert.AreEqual(numeroAtteso, realResult);

        }


        [Test]
        public void DivideTest()
        {
            Calculator calculateDivide = new Calculator();
            float num3 = -25;
            float num4 = -5;
            float valoreAtteso = 5;
            float valoreReale = calculateDivide.Divide(num3,num4);

            Assert.AreEqual(valoreAtteso, valoreReale);
        }

        [Test]
        public void DivideForZero([Random(5, 20, 2)] float num)
        {
            Calculator calculateDivide = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculateDivide.Divide(num, 0));
        }


        [Test]
        public void MultiplyTest()
        {

            // Initialize
            Calculator calculateMultiply = new Calculator();
            float num15 = 5;
            float num16 = 4;
            float numeroAtteso = 20;

            //Act
            float numeroReale = calculateMultiply.Multiply(num15, num16);

            // Assert
            Assert.AreEqual(numeroAtteso, numeroReale);

        }





    }
}