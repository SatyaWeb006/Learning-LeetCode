using System;
using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

namespace codility.com.MissingInteger
{
    [TestFixture]
    public class MissingInteger
    {
        [TestCase(new int[] {1, 3, 6, 4, 1, 2}, 5)]
        [TestCase(new int[] {1,2,3},  4)]
        [TestCase(new int[] {-1,-3},  1)]
        public void Example1(int[] nums, int assert)
        {
            var time =  Stopwatch.StartNew();
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