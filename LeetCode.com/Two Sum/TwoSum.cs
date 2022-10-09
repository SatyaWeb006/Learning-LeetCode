using System;
using System.Linq;

namespace LeetCode.com.Two_Sum
{
    /// <summary>
    ///     Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    ///     You may assume that each input would have exactly one solution, and you may not use the same element twice.
    ///     You can return the answer in any order.
    /// 
    ///     LeetCode ；https://leetcode.com/problems/two-sum/
    /// </summary>
    public class Solution
    {
        /// <summary>
        ///     解題思路 : https://www.notion.so/syuantsai/2a52eed4b34f4e00a1e49e96a66f6963
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            foreach (var eOne in nums.Select((value, i) => new {i, value}))
            {
                foreach (var eTwo in nums.Select((value, i) => new {i, value}))
                {
                    Console.WriteLine($"index  : One : {eOne.i}, Two : {eTwo.i}");
                    if (eOne.i == eTwo.i || target != (eOne.value + eTwo.value)) continue;
                    Console.WriteLine($"target : {target}, One : {eOne.value}, Two : {eTwo.value}");
                    Console.WriteLine($"Answer : One : {eOne.i}, Two : {eTwo.i}");
                    return new int[]{eOne.i, eTwo.i};
                }
            }

            return null;
        }
    }
}