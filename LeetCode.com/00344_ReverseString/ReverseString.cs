namespace LeetCode.com._00344_ReverseString
{
    /// <summary>
    /// Write a function that reverses a string. The input string is given as an array of characters s.
    /// You must do this by modifying the input array in-place with O(1) extra memory.
    ///
    /// 
    ///     解題思路 : https://www.notion.so/syuantsai/2a52eed4b34f4e00a1e49e96a66f6963
    /// </summary>
    public static class Solution
    {
        
        /// <summary>
        ///     While迴圈解法 - 1
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static char[] ReverseStringWithWhile_1(char[] input)
        {
            var left = 0;
            var right = input.Length - 1;

            while (right > left)
            {
                //  原始寫法
                // var tmp = input[left];
                // input[left] = input[right];
                // input[right] = tmp;
                
                (input[left], input[right]) = (input[right], input[left]);

                left++;
                right--;
            }
            
            return input;
        }
        
        /// <summary>
        ///     For迴圈解法 - 3
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static char[] ReverseStringWithFor_3(char[] input)
        {
            for (int i = 0, j = (input.Length -1 ); i < input.Length/2 ; i++, j--)
            {
                (input[i], input[j]) = (input[j], input[i]);
            }
            
            return input;
        }
        
        /// <summary>
        ///     For迴圈解法 - 2(語法簡化)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static char[] ReverseStringWithFor_2(char[] input)
        {
            for (var i = 0; i < input.Length/2 ; i++)
            {
                //  原始語法
                // var tmp = input[0];
                // input[0] = input[input.Length - 1];
                // input[input.Length - 1] = tmp;
                
                //  簡化1
                // var tmp = input[0];
                // input[0] = input[^1];
                // input[^1] = tmp;
                
                //  簡化2
                (input[0], input[^1]) = (input[^1], input[0]);
            }
            
            return input;
        }
        
        /// <summary>
        ///     For迴圈解法 -1 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static char[] ReverseStringWithFor_1(char[] input)
        {
            for (var i = 0; i < input.Length/2 ; i++)
            {
                var tmp = input[0];
                input[0] = input[input.Length - 1];
                input[input.Length - 1] = tmp;
            }
            
            return input;
        }
        
        /// <summary>
        ///     原生解法 - 2
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static char[] ReverseStringWithCSharp_2(char[] input)
        {
             Array.Reverse(input);
             return input;
        }
        
        /// <summary>
        ///     原生解法 -1 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static char[] ReverseStringWithCSharp_1(char[] input)
        {
            return input.Reverse().ToArray();
        }

    }
}