using AlgorithmDotnet.RectangleIntersection;
using Newtonsoft.Json;
using NUnit.Framework;

namespace AlgorithmDotnetTest
{
    class RectangleIntersection
    {
        private AlgorithmRectangleIntersection _algorithmRectangleIntersection;

        [SetUp]
        public void SetUp()
        {
            _algorithmRectangleIntersection = new AlgorithmRectangleIntersection();
        }

        [TestCase]
        public void RectangleIntersection_Normal_ReturnExpectedRectangle()
        {
            var firstRectangle = new Rectangle(1, 1, 6, 3);
            var secondRectangle = new Rectangle(5, 2, 3, 6);
            var expectedRectangle = new Rectangle(5, 2, 2, 2);

            var result = _algorithmRectangleIntersection.RectangleIntersection(firstRectangle, secondRectangle);

            var resultJson = JsonConvert.SerializeObject(result);
            var expectedRectangleJson = JsonConvert.SerializeObject(expectedRectangle);

            Assert.AreEqual(expectedRectangleJson, resultJson);
        }
    }
}
