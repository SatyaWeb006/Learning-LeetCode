using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

// ReSharper disable StringLiteralTypo

namespace Codility.Com.NumberOf1Bits
{
    [TestFixture]
    public class NumberOf1BitsTest
    {
        [TestCase(1, 1 ,1)]
        [TestCase(4,4, 1)]
        [TestCase(9,9, 3)]
        public void Example1(int numOne, int numTwo, int assert)
        {
            var time = Stopwatch.StartNew();
            var answer = new Solution();
            var result = answer.solution(numOne,numTwo);
            time.Stop();
            var times = time.ElapsedMilliseconds;

            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().Be(assert, "預期結果不一致。");
            //times.Should().BeLessThan(1000);
        }
    }
}