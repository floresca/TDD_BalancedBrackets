using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBracketKATA
{
    [TestFixture]
    public class BalancedBracketTest
    {
        [Test]
        public void ReturnEmptyString()
        {
            string input = "";
            string expected = "";
            var initialize = new BalancedBracket();
            string result = initialize.RunBalancedBracket(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ReturnOKWhenSentABalancedBracket()
        {
            string input = "[]";
            string expected = "OK";
            var initialize = new BalancedBracket();
            string result = initialize.RunBalancedBracket(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ReturnFAILWhenSentAnUnbalancedBracket()
        {
            string input = "][";
            string expected = "FAIL";
            var initialize = new BalancedBracket();
            string result = initialize.RunBalancedBracket(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ReturnOKWhenSentAStringWithEvenLength()
        {
            string input = "[[]]";
            string expected = "OK";
            var initialize = new BalancedBracket();
            string result = initialize.RunBalancedBracket(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ReturnFAILWhenSentAStringWithoutBalancedBrackets()
        {
            string input = "[[[]";
            string expected = "FAIL";
            var initialize = new BalancedBracket();
            string result = initialize.RunBalancedBracket(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ReturnOKWhenSentALongStringWithBalancedBrackets()
        {
            string input = "[[][][]]";
            string expected = "OK";
            var initialize = new BalancedBracket();
            string result = initialize.RunBalancedBracket(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ReturnFAILWhenSentALongStringWithoutBalancedBrackets()
        {
            string input = "[[[]]][]";
            string expected = "FAIL";
            var initialize = new BalancedBracket();
            string result = initialize.RunBalancedBracket(input);

            Assert.AreEqual(expected, result);
        }
    }
}
