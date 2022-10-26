using System.Diagnostics;
using FluentAssertions;
using Hackerrank.com.SimpleArraySum;
using NUnit.Framework;

// ReSharper disable StringLiteralTypo

namespace Hackerrank.com.Test.SimpleArraySum.Test
{
    [TestFixture]
    public class ThreeLettersTest
    {
        [TestCase(6, new int[] {1, 2, 3, 4, 10, 11}, 31)]
        public void Example1(int length, int[] arrInt, int assert)
        {
            var time = Stopwatch.StartNew();
            var result = Result.simpleArraySum(arrInt.ToList());
            time.Stop();
            var times = time.ElapsedMilliseconds;

            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().Be(assert, "預期結果不一致。");
            times.Should().BeLessThan(1000);
        }
    }
}