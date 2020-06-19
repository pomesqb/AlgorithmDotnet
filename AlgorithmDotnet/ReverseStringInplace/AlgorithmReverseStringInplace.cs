using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDotnet.ReverseStringInplace
{
    public class AlgorithmReverseStringInplace
    {
        public char[] ReverseStringInplace(char[] message)
        {
            return ReverseCharacter(message, 0, message.Length - 1);
        }

        public char[] ReverseWords(char[] message)
        {
            int leftWordIndex = 0;
            int rightWordIndex = 0;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ')
                    rightWordIndex++;
            }

            int leftWordHeadIndex = 0;
            int leftWordTailIndex = 0;
            int rightWordHeadIndex = 0;
            int rightWordTailIndex = message.Length - 1;

            while (leftWordIndex < rightWordIndex)
            {
                for (int i = leftWordHeadIndex; i < message.Length; i++)
                {
                    if (message[i] == ' ')
                    {
                        leftWordTailIndex = i - 1;
                        break;
                    }
                }

                for (int i = rightWordTailIndex; i >= 0; i--)
                {
                    if (message[i] == ' ')
                    {
                        rightWordHeadIndex = i + 1;
                        break;
                    }
                }

                int leftWordLength = (leftWordTailIndex - leftWordHeadIndex) + 1;
                int rightWordLength = (rightWordTailIndex - rightWordHeadIndex) + 1;

                char[] tempChars = new char[leftWordLength];
                Array.Copy(message, leftWordHeadIndex, tempChars, 0, leftWordLength);

                for (int i = rightWordHeadIndex; i < (rightWordHeadIndex + rightWordLength); i++)
                {
                    if (message[leftWordHeadIndex] == ' ')
                    {
                        for (int s = rightWordHeadIndex ; s > leftWordHeadIndex; s--)
                        {
                            message[s] = message[s - 1];
                        }
                    }

                    message[leftWordHeadIndex] = message[i];
                    leftWordHeadIndex++;
                }
                leftWordHeadIndex++;

                int tempCharIndex = tempChars.Length -1;
                for (int i = tempCharIndex; i >= 0; i--)
                {
                    message[rightWordTailIndex] = tempChars[i];
                    rightWordTailIndex--;
                }
                rightWordTailIndex--;

                leftWordIndex++;
                rightWordIndex--;
            }

            return message;
        }

        public char[] ReverseWordsBest(char[] message)
        {
            // Reverse character first
            ReverseStringInplace(message);

            int leftIndex = 0;

            // Reverse every word
            for (int i = 0; i <= message.Length; i++)
            {
                if( i == message.Length || message[i] == ' ')
                {
                    ReverseCharacter(message, leftIndex, i - 1);
                    leftIndex = i + 1;
                }
            }

            return message;
        }

        private char[] ReverseCharacter(char[] message, int leftIndex, int rightIndex)
        {
            while (leftIndex < rightIndex)
            {
                char tempChar;
                tempChar = message[leftIndex];
                message[leftIndex] = message[rightIndex];
                message[rightIndex] = tempChar;

                leftIndex++;
                rightIndex--;
            }

            return message;
        }
    }
}
