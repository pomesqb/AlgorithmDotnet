using AlgorithmDotnet.LinkedList;
using NUnit.Framework;

namespace AlgorithmDotnetTest
{
    class LinkedList
    {
        private AlgorithmLinkedList _algorithmLinkedList;

        [SetUp]
        public void SetUp()
        {
            _algorithmLinkedList = new AlgorithmLinkedList();
        }

        [TestCase]
        public void ReverseLinkedList_WhenCalled_ReturnExpectedValue()
        {
            var node1 = new LinkedListedNodeEx(1);
            var node2 = new LinkedListedNodeEx(2);
            var node3 = new LinkedListedNodeEx(3);

            node1.Next = node2;
            node2.Next = node3;

            var newHead = _algorithmLinkedList.ReverseLinkedList(node1);
            var result = _algorithmLinkedList.PrintLinkedList(newHead);

            Assert.That(result, Is.EqualTo("3,2,1"));
        }
    }
}
