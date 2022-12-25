using System.Diagnostics;
using FluentAssertions;
using Hackerrank.com.BalancedArray;
using NUnit.Framework;

namespace Hackerrank.com.Test.BalancedArray.Test
{
    [TestFixture]
    public class BalancedArrayTest
    {
        [TestCase( new int[] {1, 2, 1, 2, 1, 3}, 2)]
        [TestCase( new int[] {1, 2, 5, 2, 4, 2}, 0)]
        [TestCase( new int[] {20, 10}, 10)]
        public void Example1(int[] arrInt, int assert)
        {
            var time = Stopwatch.StartNew();
            var result = Result.BalancedArray(arrInt.ToList());
            time.Stop();
            var times = time.ElapsedMilliseconds;

            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().Be(assert, "預期結果不一致。");
            times.Should().BeLessThan(1000);
        }
    }
}