using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace AwesomeCalculator_Tests
{
    [TestFixture]
    class ClassTests
    {
        [Test]
        public void GetAddition_Inputminus99andminus1_Returnsminus100()
        {
            //Arrage
            double number1 = -99;
            double number2 = -1;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetAddition_Input2point99andminus1point99_Returns1()
        {
            //Arrage
            double number1 = 2.99;
            double number2 = -1.99;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetAddition_Input999and32768_Returns33767()
        {
            //Arrage
            double number1 = 999;
            double number2 = 32768;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Inputminus999andminus999_Returns0()
        {
            //Arrage
            double number1 = -999;
            double number2 = -999;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Inputminus10000andminus2000_Returnsminus8000()
        {
            //Arrage
            double number1 = -10000;
            double number2 = -2000;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void GetSubtraction_Input9point99and3point99_Returns6()
        {
            //Arrage
            double number1 = 9.99;
            double number2 = 3.99;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


    }
}
