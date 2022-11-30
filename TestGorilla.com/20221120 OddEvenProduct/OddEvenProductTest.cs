using System;
using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

namespace TestGorilla.com._20221120_OddEvenProduct
{
    
    [TestFixture]
    public class OddEvenProductTest
    {
        [TestCase(new[] {-1, 0, 3, 5, 9, 12}, 28)]
        [TestCase(new[] {0}, 0)]
        [TestCase(new[] {5,7,9}, 0)]
        public void Example1(int[] input, int outData)
        {
            var time =  Stopwatch.StartNew();
            var result = OddEvenProduct.odd_even_product(input);
            time.Stop();
            var times = time.ElapsedMilliseconds;
            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().Be(outData, "預期結果不一致。");
        }
    }
}