using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.com._00051_N_Queens
{
    [TestFixture]
    public partial class SolveNQueensTest
    {
        [TestCaseSource(nameof(SolveNQueens))]
        public void Example1(int nums, List<List<string>> assert)
        {
            var time = Stopwatch.StartNew();
            var result = Solution.SolveNQueens(nums);
            time.Stop();
            var times = time.ElapsedMilliseconds;
            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().BeEquivalentTo(assert, "預期結果不一致。");
            times.Should().BeLessThan(3000);
        }

        [TestCaseSource(nameof(CreateCheckerBoard))]
        public void CreateCheckerBoardTest(int nums, Dictionary<string, bool> assert)
        {
            var result = Solution.CreateCheckerBoard(nums);
            result.Should().BeEquivalentTo(assert, "預期結果不一致。");
        }

        
        [TestCaseSource(nameof(QueensExclusionArea))]
        public void QueenPlacingTest(string place, Dictionary<string,bool> assert)
        {
            var result = Solution.QueenPlacingExclusionArea(place);

            result.Should().BeEquivalentTo(assert, "預期結果不一致");
        }
    }
}