using System;
using System.Collections.Generic;

/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.


Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].

 */




namespace Array_Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            TwoSum(nums, target);
        }

        static int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {return new int[2];}

            Dictionary<int,int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, dict[target - nums[i]]};
                }
                else if (dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }

            return new int[2];
        }


    }
}
