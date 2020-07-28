using AlgorithmDotnet.BinarySearch;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDotnetTest
{
    class BinarySearch
    {
        private AlgorithmBinarySearch _algorithmBinarySearch;

        [SetUp]
        public void SetUp()
        {
            _algorithmBinarySearch = new AlgorithmBinarySearch();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 4, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 1, true)]
        [TestCase(new int[] { 1, 2}, 2, true)]
        [TestCase(new int[] { 1 }, 1, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 7, false)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 0, false)]
        [TestCase(new int[] { 1, 2}, -1, false)]
        [TestCase(new int[] { 2 }, 4, false)]
        public void BinarySearch_WhenCalled_ReturnExpectedValue(int[] nums, int target, bool expectedValue)
        {
            var result = _algorithmBinarySearch.BinarySearch(nums, target);
            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}
