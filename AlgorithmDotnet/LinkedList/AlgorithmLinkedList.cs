using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDotnet.LinkedList
{
    public class LinkedListedNodeEx
    {
        public int Value { get; set; }
        public LinkedListedNodeEx Next { get; set; }

        public LinkedListedNodeEx(int value)
        {
            Value = value;
        }
    }

    public class AlgorithmLinkedList
    {
        public LinkedListedNodeEx ReverseLinkedList(LinkedListedNodeEx head)
        {
            LinkedListedNodeEx currentNode = head;
            LinkedListedNodeEx nextNode = null;
            LinkedListedNodeEx previousNode = null;

            while (currentNode != null)
            {
                nextNode = currentNode.Next;
                currentNode.Next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }

            return previousNode;
        }

        public string PrintLinkedList(LinkedListedNodeEx node)
        {
            string result = "";

            while(node != null)
            {
                result += node.Value + ",";
                node = node.Next;
            }

            result = result.TrimEnd(',');

            return result;
        }
    }
}
