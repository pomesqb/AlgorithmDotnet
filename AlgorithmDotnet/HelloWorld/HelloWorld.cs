using System;

namespace AlgorithmDotnet.HelloWorld
{
    public class HelloWorld
    {
        public string Play(int num)
        {
            string result;

            if(num == 1)
            {
                result = "Hello";
            }
            else
            {
                result = "World";
            }

            return result;
        }
    }
}
