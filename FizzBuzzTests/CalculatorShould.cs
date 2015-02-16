using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForClient;
using System.Collections.Generic;

namespace FizzBuzzTests
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void ReturnOneWhenGivenAnInputOf1()
        {
            var customRulesList = new List<ForClient.CustomRule>();
            customRulesList.Add(new CustomRule(3, "Fizz"));
            customRulesList.Add(new CustomRule(5, "Buzz"));

            var calculator = new Calculator(customRulesList);
            var expected = "1";
            var actual = calculator.ResultGivenInputOf(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnFizzWhenGivenAnInputOfThree()
        {
            var customRulesList = new List<ForClient.CustomRule>();
            customRulesList.Add(new CustomRule(3, "Fizz"));
            customRulesList.Add(new CustomRule(5, "Buzz"));

            var calculator = new Calculator(customRulesList);
            var expected = "Fizz";
            var actual = calculator.ResultGivenInputOf(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnBuzzWhenGivenAnInputOfFive()
        {
            var customRulesList = new List<ForClient.CustomRule>();
            customRulesList.Add(new CustomRule(3, "Fizz"));
            customRulesList.Add(new CustomRule(5, "Buzz"));

            var calculator = new Calculator(customRulesList);
            var expected = "Buzz";
            var actual = calculator.ResultGivenInputOf(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnFizzBuzzWhenGivenAnInputOfFifteen()
        {
            var customRulesList = new List<ForClient.CustomRule>();
            customRulesList.Add(new CustomRule(3, "Fizz"));
            customRulesList.Add(new CustomRule(5, "Buzz"));

            var calculator = new Calculator(customRulesList);
            var expected = "FizzBuzz";
            var actual = calculator.ResultGivenInputOf(15);

            Assert.AreEqual(expected, actual);
        }
    }
}
