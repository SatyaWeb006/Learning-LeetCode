using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TestGorilla.com._20221120_CheckPassword
{
    public static class Password
    {
        public static string CheckPassword(string[] input, string check)
        {
            foreach (var t in input)
            {
                if (PasswordDetail(t, check))
                {
                    return t;
                }
            }

            return "";
        }

        private static bool PasswordDetail(string input, string check)
        {
            int.TryParse(check.Substring(0, 1), out var upCase);
            var srcFinal = check.Substring(1, 3);
            var lastStr = check.LastIndexOf(srcFinal, StringComparison.Ordinal) + 3;
            var finalStr = new string(srcFinal.Reverse().ToArray()).Replace("$", "\\$");
            var lastLen = check.Length - lastStr;
            int.TryParse(check.Substring(lastStr, lastLen), out var numSum);

            if (Regex.Matches(input, "[A-Z]").Count != upCase)
            {
                return false;
            }

            if (!Regex.IsMatch(input, $"^.*{finalStr}"))
            {
                return false;
            }

            var sum = 0;
            foreach (var str in input)
            {
                if (int.TryParse(str.ToString(), out var num))
                {
                    sum += num;
                }
            }

            return numSum == sum;
        }
    }
}