using NUnit.Framework;

namespace LeetCode.com._00344_ReverseString
{
    [TestFixture]
    public partial class ReverseStringTest
    {
        static IEnumerable<TestCaseData> ReverseStringTestCases
        {
            get
            {
                yield return
                    new TestCaseData("Case01", new[] {'h', 'e', 'l', 'l', 'o'},
                        new[] {'o', 'l', 'l', 'e', 'h'});
                yield return
                    new TestCaseData("Case02", new[] {'H', 'a', 'n', 'n', 'a', 'h'},
                        new[] {'h', 'a', 'n', 'n', 'a', 'H'});
                yield return
                    new TestCaseData("Case03", new[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l'},
                        new[] {'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a'});
                yield return
                    new TestCaseData("Case04", new[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l'},
                        new[] {'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a'});
            }
        }
    }
}