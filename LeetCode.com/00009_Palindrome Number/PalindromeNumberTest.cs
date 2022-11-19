using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.com._00009_Palindrome_Number
{
    [TestFixture]
    public class PalindromeNumberTest
    {
        [TestCase(121, true)]
        [TestCase(-121, false)]
        [TestCase(10, false)]
        [TestCase(1, true)]
        [TestCase(11, true)]
        [TestCase(1000030001, false)]
        public void Example1(int nums, bool assert)
        {
            //var time = Stopwatch.StartNew();
            var result = Solution.IsPalindrome(nums);
            //time.Stop();
            //var times = time.ElapsedMilliseconds;
            //Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().Be(assert, "預期結果不一致。");
            //times.Should().BeLessThan(1000);
        }
    }
}