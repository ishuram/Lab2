﻿using System;
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
        public void GetAddition_Inputminus99andminus1_Returnsminus100() //testcase1
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
        public void GetAddition_Input2point99andminus1point99_Returns1()  //testcase2
        {
            //Arrage
            double number1 = 2.99;
            double number2 = -1.99;

            
            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(1.00, actualResult);

        }
        [Test]
        public void GetAddition_Input999and32768_Returns33767()  //testcase3
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
        public void GetSubtraction_Inputminus999andminus999_Returns0()  //testcase4
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
        public void GetSubtraction_Inputminus10000andminus2000_Returnsminus8000() //testcase5
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
        public void GetSubtraction_Input9point99and3point99_Returns6()  //testcase6
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
        [Test]
        public void GetMultiplication_Input3point9and3point3_Returns12point87()  //testcase7
        {
            //Arrage
            double number1 = 3.9;
            double number2 = 3.3;

            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);

            //Act
                        double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultiplication_Input0and0_Returns0()  //testcase8
        {
            //Arrage
            double number1 = 0;
            double number2 = 0;

            
            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(0, actualResult);

        }

        [Test]
        public void GetMultiplication_Inputminus7andminus9_Returnsminus63() //testcase9
        {
            //Arrage
            double number1 = -7;
            double number2 = -9;

            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void GetDivision_Inputminus10andminus5_Returnsminus2()  //testcase10
        {
            //Arrage
            double number1 = -10;
            double number2 = -5;

            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void GetDivision_Input8point8andminus2_Returnsminus4point4()  //testcase11
        {
            //Arrage
            double number1 = 8.8;
            double number2 = -2;

            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void GetDivision_Input0and1_Returns0() //testcase12
        {
            //Arrage
            double number1 = 0;
            double number2 = 1;

            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }



    }
}
