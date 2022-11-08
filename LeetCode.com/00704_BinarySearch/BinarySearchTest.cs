using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.com._00704_BinarySearch
{
    [TestFixture]
    public class BinarySearchTest
    {
        [TestCase(new[] {-1, 0, 3, 5, 9, 12}, 9, 4)]
        [TestCase(new[] {-1, 0, 3, 5, 9, 12}, 2, -1)]//
        [TestCase(new[] {0}, 0, 0)]
        [TestCase(new[] {0}, 1, -1)]
        [TestCase(new[] {5}, 5, 0)]
        [TestCase(new[] {0,1}, 0, 0)]
        [TestCase(new[] {0,1}, 1, 1)]
        [TestCase(new[] {0,1}, 2, -1)]
        public void Example1(int[] nums, int target, int assert)
        {
            var time = Stopwatch.StartNew();
            var answer = new Solution();
            var result = Solution.BinarySearch(nums, target);
            time.Stop();
            var times = time.ElapsedMilliseconds;
            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().Be(assert, $"結果錯誤預期值{assert}，實際值為{result}。");
            times.Should().BeLessThan(1000);
        }
    }
}