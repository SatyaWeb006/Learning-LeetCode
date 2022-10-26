namespace Codility.Com.NumberOf1Bits
{
    public class Solution
    {
        /// <summary>
        ///     透過正則表示法處理
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int solution(int one, int two)
        {
            var data = Multiply(one, two);
            var result = SolutionBinary(data);
            return result;
        }

        /// <summary>
        ///     兩數相乘
        /// </summary>
        /// <param name="numOne"></param>
        /// <param name="numTwo"></param>
        /// <returns></returns>
        private int Multiply(int numOne, int numTwo)
        {
            var result = numOne * numTwo;
            return result;
        }

        /// <summary>
        ///     數值轉字串後再轉Char去統計有多少個1。
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private int CountBinaryFromString(int number)
        {
            var data = Convert.ToString(number, 2);
            Console.WriteLine(data);
            var binary = data.ToCharArray();
            var result = binary.Count(b => b == '1');
            return result;
        }


        /// <summary>
        ///     第一種解法；使用正則表示法
        /// </summary>
        /// <returns></returns>
        public int SolutionBinary(int number)
        {
            int count = 0;
            while (number != 0)
            {
                count++;
                var data = Convert.ToString(number, 2);
                Console.WriteLine($"原始值轉位元：{data}");
                Console.WriteLine($"減一後的位元：{Convert.ToString(number - 1, 2)}");
                number &= (number - 1); //關鍵演算之處

                Console.WriteLine($"移位後的位元：{Convert.ToString(number, 2)}");
                Console.WriteLine();
            }

            return count;
        }
    }
}