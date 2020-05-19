using AlgorithmDotnet;
using AlgorithmDotnet.HelloWorld;
using NUnit.Framework;

namespace AlgorithmDotnetTest.HelloWorldTest
{
    public class HelloWorldTest
    {
        private HelloWorld _helloWorld;

        [SetUp]
        public void Setup()
        {
            _helloWorld = new HelloWorld();
        }

        [Test]
        [TestCase(1, "Hello")]
        [TestCase(2, "Hello")]
        [TestCase(3, "World")]
        public void Play_WhenCalled_RetrunExpectedValue(int num, string expectedValue)
        {
            var result = _helloWorld.Play(num);

            Assert.That(result == expectedValue);
        }
    }
}