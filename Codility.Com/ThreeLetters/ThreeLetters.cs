using System.Text.RegularExpressions;

namespace Codility.Com.ThreeLetters
{
    public class Solution
    {
        /// <summary>
        ///     透過正則表示法處理
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int solution(string s)
        {
            var result = SolutionRegex(s);
            return result;
        }


        /// <summary>
        ///     第一種解法；使用正則表示法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private int SolutionRegex(string str)
        {
            var regex = new Regex("a{3,}|b{3,}");

            var result = regex.Matches(str);

            return result.Count;
        }
    }
}