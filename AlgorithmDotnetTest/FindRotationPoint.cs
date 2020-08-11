using AlgorithmDotnet.FindRotationPoint;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDotnetTest
{
    public class FindRotationPoint
    {
        private AlgorithmFindRotationPoint _algorithmFindRotationPoint;

        [SetUp]
        public void SetUp()
        {
            _algorithmFindRotationPoint = new AlgorithmFindRotationPoint();
        }

        [TestCase(new string[] { "ptolemaic", "retrograde", "supplant", "undulate", "xenoepist","asymptote", "babka", "banoffee", "engender", "karpatka", "othellolagkage" }, 5)]
        [TestCase(new string[] { "ptolemaic", "asymptote" }, 1)]
        public void FindRotationPoint_WhenCalled_ReturnExpectedValue(string[] words, int expectedValue)
        {
            var result = _algorithmFindRotationPoint.FindRotationPoint(words);
            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}
