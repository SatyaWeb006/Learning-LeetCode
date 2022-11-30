using FluentAssertions;
using NUnit.Framework;
using OnlineInterview.CloudLatitudeCompany;

namespace OnlineInterviewTest.CloudLatitudeCompanyTest
{
    [TestFixture]
    public class TwoSumTest
    {
        [TestCase(new int[] {2, 7, 11, 15}, 9, new int[] {0, 1})]
        [TestCase(new int[] {3, 2, 4}, 6, new int[] {1, 2})]
        [TestCase(new int[] {3, 3}, 6, new int[] {0, 1})]
        public void Example1(int[] nums, int target, int[] assert)
        {
            var result = CloudLatitude.TwoSum_暴力解(nums, target);
         
            result.Should().BeEquivalentTo(assert, "預期結果不一致。");
        }
    }
}