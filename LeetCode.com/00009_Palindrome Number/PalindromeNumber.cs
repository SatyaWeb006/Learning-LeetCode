namespace LeetCode.com._00009_Palindrome_Number
{
    /// <summary>
    ///     Given an integer `x`, return `true` if `x` is a ***palindrome***, and `false` otherwise.
    ///     給予一個整數X，如果是[回文]回傳True，否則回傳Falae
    /// 
    ///     LeetCode ；https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public static class Solution
    {
        /// <summary>
        ///     解題思路 : https://www.notion.so/syuantsai/00009-Palindrome-Number-53f39ff3247b488e8681220cf68c8d44
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            var input = x.ToString().ToCharArray();
            
            if (input[0] ==  '-')
            {
                return false;
            }

            int maxIndex = input.Count();
            for (int i = 0; i < maxIndex/2 ; i++)
            {
                if (input[i] == input[maxIndex])
                {
                    maxIndex--;
                    continue;
                }
                
                
            }
            
            
            return true;
        }
    }
}