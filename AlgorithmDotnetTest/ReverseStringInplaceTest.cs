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

        [TestCase(
            new char[] { 'a', 'b', 'c', 'd', 'e'},
            new char[] { 'e', 'd', 'c', 'b', 'a'})]
        [TestCase(
            new char[] { 'a', 'b', 'c', 'd'},
            new char[] { 'd', 'c', 'b', 'a'})]
        [TestCase(
            new char[] { 'a', 'b', 'c', '1', '2', '3' },
            new char[] { '3', '2', '1', 'c', 'b', 'a' })]
        public void ReverseStringInplace_WhenCalled_ReturnExpectedValue(char[] originalStr, char[] expectedValue)
        {
            var result = _algorithmReverseStringInplace.ReverseStringInplace(originalStr);
            Assert.That(result, Is.EqualTo(expectedValue));
        }

        [TestCase(
            new char[] { 'c', 'a', 'k', 'e', ' ', 'p', 'o', 'u', 'n', 'd', ' ', 's', 't', 'e', 'a', 'l'},
            new char[] { 's', 't', 'e', 'a', 'l', ' ', 'p', 'o', 'u', 'n', 'd', ' ', 'c', 'a', 'k', 'e'})]
        [TestCase(
            new char[] { 'a', 'b', ' ', 'c', 'd', ' ', 'e', 'f', ' ', 'g', 'h'},
            new char[] { 'g', 'h', ' ', 'e', 'f', ' ', 'c', 'd', ' ', 'a', 'b' })]
        [TestCase(
            new char[] { 'a', ' ', 'c', 'd', ' ', 'f', ' ', 'g', 'h' },
            new char[] { 'g', 'h', ' ', 'f', ' ', 'c', 'd', ' ', 'a' })]
        public void ReverseWords_WhenCalled_ReturnExpectedValue(char[] originalStr, char[] expectedValue)
        {
            var result = _algorithmReverseStringInplace.ReverseWords(originalStr);
            Assert.That(result, Is.EquivalentTo(expectedValue));
        }

        [TestCase(
            new char[] { 'c', 'a', 'k', 'e', ' ', 'p', 'o', 'u', 'n', 'd', ' ', 's', 't', 'e', 'a', 'l' },
            new char[] { 's', 't', 'e', 'a', 'l', ' ', 'p', 'o', 'u', 'n', 'd', ' ', 'c', 'a', 'k', 'e' })]
        public void ReverseWordsBest_WhenCalled_ReturnExpectedValue(char[] originalStr, char[] expectedValue)
        {
            var result = _algorithmReverseStringInplace.ReverseWordsBest(originalStr);
            CollectionAssert.AreEqual(expectedValue, result);
        }
    }
}
