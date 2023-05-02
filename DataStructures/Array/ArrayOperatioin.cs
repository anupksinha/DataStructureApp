using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ArrayOperation
{
    public class ArrayOperation
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxCount = 0;
            int currCount = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] == 1)
                {
                    currCount += 1;
                    maxCount = Math.Max(maxCount, currCount);
                }
                else
                    currCount = 0;
            }
            return maxCount;
        }


        public int FindNumbersWithEvenDigits(int[] nums)
        {
            int count = 0;
            foreach (int num in nums)
            {
                string strNum = num.ToString();
                if (strNum.Length % 2 == 0)
                    count++;
            }
            return count;
        }

        public int[] SortedSquares(int[] nums)
        {
            int[] squaredArr = new int[nums.Length];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                int squaredNum = nums[i] * nums[i];
                squaredArr[i] = squaredNum;
            }
            Array.Sort(squaredArr);
            return squaredArr;
        }

        public void DuplicateZeros(int[] arr)
        {
            int zeroes = 0;
            foreach (int val in arr)
            {
                if (val == 0)
                {
                    zeroes++;
                }

            }
            int i = arr.Length - 1;
            int j = arr.Length + zeroes - 1;
            int diff = j - i;
            // i = i - diff;
            // j = j - diff;

            bool SecontPass = false;

            while (i != j)
            {

                if (arr[i] != 0)
                {
                    if (j <= arr.Length - 1)
                    {
                        arr[j] = arr[i];
                    }
                    i--;
                    j--;
                }
                else if (arr[i] == 0)
                {
                    if (j <= arr.Length - 1)
                    {
                        arr[j] = arr[i];
                    }
                    j--;
                    if (SecontPass == false)
                    {
                        SecontPass = true;
                    }
                    else if (SecontPass == true)
                    {
                        i--;
                        SecontPass = false;
                    }
                }
            }

        }
    }
}
