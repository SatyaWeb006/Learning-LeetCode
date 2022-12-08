using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.com._00344_ReverseString
{
    [TestFixture]
    public partial class ReverseStringTest
    {
        [TestCaseSource(nameof(ReverseStringTestCases))]
        public void Example21(string _, char[] input, char[] assert)
        {
            var time = Stopwatch.StartNew();
            var result = Solution.ReverseStringWithWhile_1(input);
            time.Stop();
            var times = time.ElapsedMilliseconds;
            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().BeEquivalentTo(assert, "預期結果不一致。");
            times.Should().BeLessThan(3000);
        }
        
        [TestCaseSource(nameof(ReverseStringTestCases))]
        public void Example13(string _, char[] input, char[] assert)
        {
            var time = Stopwatch.StartNew();
            var result = Solution.ReverseStringWithFor_3(input);
            time.Stop();
            var times = time.ElapsedMilliseconds;
            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().BeEquivalentTo(assert, "預期結果不一致。");
            times.Should().BeLessThan(3000);
        }
        
        [TestCaseSource(nameof(ReverseStringTestCases))]
        public void Example12(string _, char[] input, char[] assert)
        {
            var time = Stopwatch.StartNew();
            var result = Solution.ReverseStringWithFor_2(input);
            time.Stop();
            var times = time.ElapsedMilliseconds;
            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().BeEquivalentTo(assert, "預期結果不一致。");
            times.Should().BeLessThan(3000);
        }
        
        [TestCaseSource(nameof(ReverseStringTestCases))]
        public void Example11(string _, char[] input, char[] assert)
        {
            var time = Stopwatch.StartNew();
            var result = Solution.ReverseStringWithFor_1(input);
            time.Stop();
            var times = time.ElapsedMilliseconds;
            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().BeEquivalentTo(assert, "預期結果不一致。");
            times.Should().BeLessThan(3000);
        }
        
        [TestCaseSource(nameof(ReverseStringTestCases))]
        public void Example02(string _, char[] input, char[] assert)
        {
            var time = Stopwatch.StartNew();
            var result = Solution.ReverseStringWithCSharp_2(input);
            time.Stop();
            var times = time.ElapsedMilliseconds;
            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().BeEquivalentTo(assert, "預期結果不一致。");
            times.Should().BeLessThan(3000);
        }
        
        [TestCaseSource(nameof(ReverseStringTestCases))]
           public void Example01(string _, char[] input, char[] assert)
        {
            var time = Stopwatch.StartNew();
            var result = Solution.ReverseStringWithCSharp_1(input);
            time.Stop();
            var times = time.ElapsedMilliseconds;
            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().BeEquivalentTo(assert, "預期結果不一致。");
            times.Should().BeLessThan(3000);
        }
    }
}