using System;

namespace TestGorilla.com._20221120_OddEvenProduct
{
    public static class OddEvenProduct
    {
        public static int odd_even_product( int[] input )
        {

            int data = input[0];
            
            for (int i = 1; i < (input.Length-1); i++)
            {
                data *= input[i];
                Console.WriteLine(data);
            }

            var result = 0;
            if (data % 2 == 0)
            {
                foreach (var inNum in input)
                {
                    result += inNum;
                }
            }
            else
            {
                return 0;
            }

            return result;

        }
    }
}