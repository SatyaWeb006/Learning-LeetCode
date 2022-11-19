using System;
using System.Globalization;

namespace TestGorilla.com._00000_Sample_Test
{
    public static class Sample
    {
        public static string ConvertFrom12To24HoursFormat(string inputTime)
        {
            DateTime.TryParse(inputTime, out var time);
            return time.ToString("H:mm", CultureInfo.CurrentCulture);
        }
    }
}