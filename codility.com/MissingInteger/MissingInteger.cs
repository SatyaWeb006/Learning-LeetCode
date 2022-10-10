using System;
using System.Collections.Generic;
using System.Linq;

namespace codility.com.MissingInteger
{
    // you can also use other imports, for example:
    // using System.Collections.Generic;

    // you can write to stdout for debugging purposes, e.g.
    // Console.WriteLine("this is a debug message");
    //  解析筆記：https://www.notion.so/syuantsai/1-8ecfb765c2d2446caa3b9f0049a6c691
    //  GitLab ：https://gitlab.com/SyuanTsai/Learning/LeetCode.git
    
    public class Solution
    {
        /// <summary>
        ///     不先產生雜湊表，
        ///     反向過來透過來源資料生產雜湊表，
        ///     再逐一比對缺少的元素。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int solution(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (num < 0) continue;
                if (dic.TryGetValue(num, out _))
                {
                    continue;
                }

                dic.Add(num, num);
            }

            for (var i = 1; i <= 10000; i++)
            {
                if (dic.TryGetValue(i, out _))
                {
                    continue;
                }

                return i;
            }

            throw new ArgumentNullException(nameof(nums), "Out Of Range.");
        }


        /// <summary>
        ///     直接生出所有的資料列，
        ///     排除掉已經有的資料後取最小值。
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int 暴力解v1(int[] a)
        {
            var hash = new List<int>();
            for (int i = 1; i <= 10000; i++)
            {
                hash.Add(i);
            }

            foreach (var num in a)
            {
                hash.Remove(num);
            }

            return hash.Min();
        }
    }
}