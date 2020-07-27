using AlgorithmDotnet.InflightEntertainment;
using NUnit.Framework;

namespace AlgorithmDotnetTest
{
    class CanTwoMoviesFillFlight
    {
        AlgorithmCanTwoMoviesFillFlight _algorithmCanTwoMoviesFillFlight;

        [SetUp]
        public void SetUp()
        {
            _algorithmCanTwoMoviesFillFlight = new AlgorithmCanTwoMoviesFillFlight();
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5}, 8, true)]
        [TestCase(new int[] { 8, 4, 6, 3, 7}, 10, true)]
        [TestCase(new int[] { 8, 4, 6, 3, 7 }, 19, false)]
        [TestCase(new int[] { 8, 4, 6, 3, 7 }, 20, false)]
        public void CanTwoMoviesFillFlight_WhenCalled_ReturnExpectedValue(int[] movieLengths, int flightLength, bool expectedValue)
        {
            var result = _algorithmCanTwoMoviesFillFlight.CanTwoMoviesFillFlight(movieLengths, flightLength);
            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}
