using System;
using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

namespace TestGorilla.com._00000_Sample_Test
{
    
    [TestFixture]
    public class SampleTest
    {
        [TestCase("12:00 am","0:00")]
        [TestCase("11:00 pm","23:00")]
        public void Example1(string inputTime, string outTime)
        {
            var time =  Stopwatch.StartNew();
            var result = Sample.ConvertFrom12To24HoursFormat(inputTime);
            time.Stop();
            var times = time.ElapsedMilliseconds;
            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().BeEquivalentTo(outTime, "預期結果不一致。");
        }
    }
}