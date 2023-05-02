using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.TwoSum
{
    public class TwoSum
    {
        public int[] TwoSumLinearSearch(int[] nums, int target)
        {
            int[] twoSumArr = new int[2] {0,0 };

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        twoSumArr[0] = i;
                        twoSumArr[1] = j;
                        return twoSumArr;
                    }
                }
            }
            return twoSumArr;
        }

        public int[] TwoSumUsingHashMap(int[] nums, int target) 
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (!ht.ContainsKey(nums[i]))
                    ht.Add(nums[i], i);
            }

            foreach (int i in ht.Keys)
            {
                  int complement = target - i;
                if (ht.ContainsKey(complement))
                    if ((int)ht[i] <= (int)ht[complement])
                        return new int[] { (int)ht[i], (int)ht[complement] };
                    else if ((int)ht[i] > (int)ht[complement])
                        return new int[] { (int)ht[complement], (int)ht[i] };
                    else if ((int)ht[i] == (int)ht[complement])
                    {
                        return new int[] { (int)ht[i], (int)ht[i] + 1 };
                    }
            }
            return new int[] {0,0 };
        }
    }
}
