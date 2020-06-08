using AlgorithmDotnet.MergeMeetingTimes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDotnetTest
{
    class MergeMeetingTimesTest
    {
        private AlgorithmMergeMeetingTimes _algorithmMergeMeetingTimes;

        private static readonly object[] _data =
        {
            new object[] {
                "Case1",
                new List<Meeting> { new Meeting(1, 2), new Meeting(2, 3) },
                new List<Meeting> { new Meeting(1, 3) },
            },

            new object[] {
                "Case2",
                new List<Meeting> { new Meeting(2, 6), new Meeting(3, 7) },
                new List<Meeting> { new Meeting(2, 7) }
            },

            new object[] {
                "Case3",
                new List<Meeting> { new Meeting(3, 5), new Meeting(6, 7), new Meeting(5, 8)},
                new List<Meeting> { new Meeting(3, 8)}
            },

            new object[] {
                "Case4",
                new List<Meeting> { new Meeting(0, 1), new Meeting(3, 5), new Meeting(4, 8), new Meeting(10, 12), new Meeting(9, 10)},
                new List<Meeting> { new Meeting(0, 1), new Meeting(3, 8), new Meeting(9, 12) }
            }
        };

        [SetUp]
        public void Setup()
        {
            _algorithmMergeMeetingTimes = new AlgorithmMergeMeetingTimes();
        }

        [Test]
        [TestCaseSource(nameof(_data))]
        public void MergeMeetingTimes_WhenCalled_RetrunExpectedValue(string testName, List<Meeting> meetings, List<Meeting> expectedValue)
        {
            var result = _algorithmMergeMeetingTimes.MergeMeetingTimes(meetings);
            Assert.That(result, Is.EquivalentTo(expectedValue));
        }

        [Test]
        [TestCaseSource(nameof(_data))]
        public void MergeMeetingTimesBest_WhenCalled_RetrunExpectedValue(string testName, List<Meeting> meetings, List<Meeting> expectedValue)
        {
            var result = _algorithmMergeMeetingTimes.MergeMeetingTimesBest(meetings);
            Assert.That(result, Is.EquivalentTo(expectedValue));
        }
    }
}
