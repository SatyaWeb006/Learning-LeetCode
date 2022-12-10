using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.com._00051_N_Queens
{
    [TestFixture]
    public class TemplateTest
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


        static IEnumerable<TestCaseData> SolveNQueens
        {
            get
            {
                yield return
                    new TestCaseData(4, new List<List<string>>()
                    {
                        new()
                        {
                            ".Q..", "...Q", "Q...", "..Q."
                        },
                        new()
                        {
                            "..Q.", "Q...", "...Q", ".Q.."
                        }
                    });

                yield return
                    new TestCaseData(1, new List<List<string>>()
                    {
                        new()
                        {
                            "Q"
                        }
                    });
            }
        }
    }
}