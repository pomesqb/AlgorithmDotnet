using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDotnet.FindRotationPoint
{
    public class AlgorithmFindRotationPoint
    {
        public int FindRotationPoint(string[] words)
        {
            int leftIndex = 0;
            int rightIndex = words.Length - 1;
            string firstWord = words[0];

            while (leftIndex < rightIndex)
            {
                int midIndex = (leftIndex + rightIndex) / 2;

                if(string.CompareOrdinal(firstWord, words[midIndex]) > 0)
                {
                    rightIndex = midIndex;
                }
                else if(string.CompareOrdinal(firstWord, words[midIndex]) < 0)
                {
                    leftIndex = midIndex;
                }

                if (leftIndex + 1 == rightIndex)
                    return rightIndex;
            }

            return -1;
        }
    }
}
