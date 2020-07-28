using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDotnet.BinarySearch
{
    public class AlgorithmBinarySearch
    {
        public bool BinarySearch(int[] nums, int target)
        {
            int leftIndex = 0;
            int rightIndex = nums.Length - 1;

            while(leftIndex <= rightIndex)
            {
                int midIndex = (leftIndex + rightIndex) / 2;

                if (target == nums[midIndex])
                    return true;

                if(target < nums[midIndex])
                {
                    rightIndex = midIndex - 1;
                }
                else
                {
                    leftIndex = midIndex + 1;
                }
            }

            return false;
        }
    }
}
