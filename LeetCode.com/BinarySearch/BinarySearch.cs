using System;

namespace LeetCode.com.BinarySearch
{
    /// <summary>
    ///     Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
    ///     You must write an algorithm with O(log n) runtime complexity.
    /// </summary>
    public class Solution
    {
        /// <summary>
        ///     解題思路 : https://www.notion.so/syuantsai/2a52eed4b34f4e00a1e49e96a66f6963
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] nums, int target)
        {
            var result = Search(nums, target, nums.Length);
            return result;
        }

        private static int Search(int[] nums, int target, int maxLength, int left = 1)
        {
            while (true)
            {
                //Console.WriteLine($"陣列長度{nums.Length}, 現在左界線{left}, 現在右界線{maxLength}");
                var range = maxLength - left;
                if (range <= 1)
                {
                    //Console.WriteLine("極限值判斷");
                    if (nums[left - 1] == target)
                    {
                        return left - 1;
                    }

                    if (nums[maxLength - 1] == target)
                    {
                        return maxLength - 1;
                    }

                    return -1;
                }

                Console.WriteLine("範圍取值");
                //  取得中位
                var spilt = range / 2;
                //  指定本次取值的index
                var index = maxLength - spilt;
                //  取出
                var num = nums[index];
                if (num == target)
                {
                    return index;
                }

                if (num > target)
                {
                    maxLength = index;
                }
                else if (num < target)
                {
                    left = index;
                }
            }
        }
    }
}