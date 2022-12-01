using FluentAssertions;
using NUnit.Framework;
using OnlineInterview.CloudLatitudeCompany;

namespace OnlineInterviewTest.CloudLatitudeCompanyTest
{
    [TestFixture]
    public class TwoSumTest
    {
        [TestCase(5, "1 2 fizz 4 buzz")]
        [TestCase(6, "1 2 fizz 4 buzz fizz")]
        [TestCase(15, "1 2 fizz 4 buzz fizz dizz 8 fizz buzz 11 fizz 13 dizz fizzbuzz")]
        [TestCase(21, "1 2 fizz 4 buzz fizz dizz 8 fizz buzz " +
                      "11 fizz 13 dizz fizzbuzz 16 17 fizz 19 buzz fizzdizz")]
        public void Example1(int input, string target)
        {
            var result = CloudLatitude.SomeMethod(input);

            result.Should().BeEquivalentTo(target,
                "預期結果不一致。");
        }
    }
}