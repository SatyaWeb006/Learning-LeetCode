using System;
using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

namespace TestGorilla.com._20221120_CheckPassword
{
    [TestFixture]
    public class CheckPasswordTest
    {
        [TestCase(new[] {"P@sswORD1", "20passWORD20", "PASS6word"}, "4dro6", "PASS6word")]
        [TestCase(new[] {"theBestpassword", "myPassword#3"}, "1dro0", "theBestpassword")]
        [TestCase(new[] {"MyPassword2", "crazyPassword1#$%"}, "1%$#1", "crazyPassword1#$%")]
        [TestCase(new[] {"luckyPASSWORD#$$$", "luckyDat666#3"}, "6pass7", "")]
        public void Example1(string[] input, string checkData, string outData)
        {
            var time = Stopwatch.StartNew();
            var result = Password.CheckPassword(input, checkData);
            time.Stop();
            var times = time.ElapsedMilliseconds;
            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().Be(outData, "預期結果不一致。");
        }


        [TestCase(new[] {"PASS6word"}, "4dro6", "PASS6word")]
        public void Example2(string[] input, string checkData, string outData)
        {
            var time = Stopwatch.StartNew();
            var result = Password.CheckPassword(input, checkData);
            time.Stop();
            var times = time.ElapsedMilliseconds;
            Console.WriteLine(time.ElapsedMilliseconds);
            result.Should().Be(outData, "預期結果不一致。");
        }
    }
}