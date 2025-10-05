using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class TwoSum
    {
		 // Problem Statement:
		  
		 // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

         //  You may assume that each input would have exactly one solution, and you may not use the same element twice.

         // You can return the answer in any order.

         // Brute Force:
		 // TC: O(n^2)
		 
        public int[] TwoSumBF(int[] nums, int target)
        {
           

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

        // Optimal solution
		// TC: O(n)
		// SC:O(n)
        public int[] TwoSumOptimal(int[] nums, int target)
        {
            

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
