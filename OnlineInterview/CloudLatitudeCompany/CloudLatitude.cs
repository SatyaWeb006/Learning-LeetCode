namespace OnlineInterview.CloudLatitudeCompany
{
    /// <summary>
    ///     緯雲
    /// </summary>
    public class CloudLatitude
    {
        /// <summary>
        ///   需求
        ///     第一階段
        ///         一個input 正整數，排除負值、0。 
        ///         回傳一個字串 數字1空格2空格3
        ///         input 5 => 「1 2 3 4 5」
        ///     第二階段
        ///         3或3的倍數不要印數字改成fizz
        ///
        ///     第三階段
        ///         5或5的倍數 輸出 buzz
        ///         共同倍數 fizzbuzz
        ///
        ///     第四階段
        ///         7或7的倍數 輸出 dizz
        ///         共同倍數 fizzbuzzdizz
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static string SomeMethod(int nums)
        {
            var dataList = new List<string>();

            for (int i = 1; i <= nums; i++)
            {
                dataList.Add(OutputString(i));
            }

            var result = string.Join(" ", dataList);
            return result;
        }

        /// <summary>
        /// 
        ///         3跟3的倍數不要印，fizz
        ///
        ///         5 或5的倍數 輸出 buzz
        ///         共同倍數 fizzbuzz
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private static string OutputString(int i)
        {
            //  重構 => 維護的阻礙
            //  1. 參數過多會不斷的增長
            //  2. tmpStr 的行為是固定模式
            //  違反了OCP原則 
            //  新增一個數值都要改2個地方。
            //  應該思考有沒有辦法只新增一個地方。
            
            var isThree = i % 3 == 0;
            var isFive = i % 5 == 0;
            var isSeven = i % 7 == 0;

            var tmpStr = string.Empty;
            
            if (isThree)
            {
                tmpStr += "fizz";
            }

            if (isFive)
            {
                tmpStr += "buzz";
            }

            if (isSeven)
            {
                tmpStr += "dizz";
            }

            return string.IsNullOrEmpty(tmpStr) ? i.ToString() : tmpStr;
        }
    }
}