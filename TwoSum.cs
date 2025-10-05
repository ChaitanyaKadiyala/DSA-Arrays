using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class TwoSum
    {

        public int[] TwoSumBF(int[] nums, int target)
        {
            // Brute Force:

            for (int i = 0; i < nums.Length; i++) {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return [];
        }

        public int[] TwoSumOptimal(int[] nums, int target)
        {
            // Brute Force:

            Dictionary<int,int> dict = new Dictionary<int,int>();

            for (int i= 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                if (dict.ContainsKey(diff))
                {
                    return new int[] { dict[diff], i };
                }

                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = i;
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }
            return [];
        }
    }
}
