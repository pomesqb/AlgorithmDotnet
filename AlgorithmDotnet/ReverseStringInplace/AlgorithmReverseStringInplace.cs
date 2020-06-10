using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDotnet.ReverseStringInplace
{
    public class AlgorithmReverseStringInplace
    {
        public string ReverseStringInplace(string inputStr)
        {
            var inputSB = new StringBuilder(inputStr);

            int leftIndex = 0;
            int rightIndex = inputStr.Length - 1;

            while (leftIndex < rightIndex)
            {
                char tempChar;
                tempChar = inputStr[leftIndex];
                inputSB[leftIndex] = inputSB[rightIndex];
                inputSB[rightIndex] = tempChar;

                leftIndex++;
                rightIndex--;
            }

            return inputSB.ToString();
        }
    }
}
