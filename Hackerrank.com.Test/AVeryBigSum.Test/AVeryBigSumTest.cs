using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

// ReSharper disable StringLiteralTypo

namespace Hackerrank.com.Test.AVeryBigSum.Test
{
    [TestFixture]
    public class AVeryBigSumTest
    {
        [TestCase(5, new long[] {1000000001, 1000000002, 1000000003, 1000000004, 1000000005}, 5000000015)]
        public void Example1(int length, long[] arrLong, long assert)
        {
            var time = Stopwatch.StartNew();
            var result = Hackerrank.com.AVeryBigSum.Result.AVeryBigSum(arrLong.ToList());
            time.Stop();
            var times = time.ElapsedMilliseconds;

            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().Be(assert, "預期結果不一致。");
            times.Should().BeLessThan(1000);
        }
    }
}