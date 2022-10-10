using System;
using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

// ReSharper disable StringLiteralTypo

namespace codility.com.ThreeLetters
{
    [TestFixture]
    public class ThreeLettersTest
    {
        [TestCase("baaaaa", 1)]
        [TestCase("baaabbaabbba", 2)]
        [TestCase("baabab", 0)]
        public void Example1(string nums, int assert)
        {
            var time = Stopwatch.StartNew();
            var answer = new Solution();
            var result = answer.solution(nums);
            time.Stop();
            var times = time.ElapsedMilliseconds;

            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().Be(assert, "預期結果不一致。");
            times.Should().BeLessThan(1000);
        }
    }
}