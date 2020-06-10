using AlgorithmDotnet.ReverseStringInplace;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDotnetTest
{
    class ReverseStringInplaceTest
    {
        AlgorithmReverseStringInplace _algorithmReverseStringInplace;

        [SetUp]
        public void SetUp()
        {
            _algorithmReverseStringInplace = new AlgorithmReverseStringInplace();
        }

        [TestCase("abcde", "edcba")]
        [TestCase("abcd", "dcba")]
        [TestCase("abc123", "321cba")]
        [TestCase("", "")]
        public void ReverseStringInplace_WhenCalled_ReturnExpectedValue(string originalStr, string expectedValue)
        {
            var result = _algorithmReverseStringInplace.ReverseStringInplace(originalStr);
            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}
