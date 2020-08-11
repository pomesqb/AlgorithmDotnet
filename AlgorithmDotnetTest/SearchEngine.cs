using AlgorithmDotnet.SearchEngine;
using NUnit.Framework;

namespace AlgorithmDotnetTest
{
    class SeachEngine
    {
        private AlgorithmSearchEngine _algorithmSearchEngine;

        [SetUp]
        public void SetUp()
        {
            _algorithmSearchEngine = new AlgorithmSearchEngine();
        }

        [TestCase]
        public void AddWord_WhenCalled_ReturnExpectedValue()
        {
            var result = _algorithmSearchEngine.AddWord("hello");
            Assert.True(result);

            result = _algorithmSearchEngine.AddWord("hello");
            Assert.False(result);

            result = _algorithmSearchEngine.AddWord("mygod");
            Assert.True(result);

            result = _algorithmSearchEngine.AddWord("hello");
            Assert.False(result);
        }
    }
}
