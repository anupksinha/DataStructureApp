using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.MaxSubarray
{
    public class MaxSubarray
    {
        public int GetMaxSubarray(int[] nums) 
        {
            int currSum;
            int maxSum = Int32.MinValue;
            for(int i = 0; i <= nums.Length-1; i++ )
            {
                currSum = 0;
                for (int j = i; j <= nums.Length-1; j++)
                {
                    currSum += nums[j];
                    maxSum = Math.Max(currSum, maxSum);
                }
            }
            return maxSum;
        }

        public int GetMinSubarrayOptimized (int[] nums)
        {
            int currSubarr = nums[0];
            int maxSubarr = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                currSubarr = Math.Max(nums[i] + currSubarr, nums[i]);
                maxSubarr = Math.Max(maxSubarr, currSubarr);
            }
            return maxSubarr;
        }


       

    }
}
