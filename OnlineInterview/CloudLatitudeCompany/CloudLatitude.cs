namespace OnlineInterview.CloudLatitudeCompany
{
    /// <summary>
    ///     緯雲
    /// </summary>
    public class CloudLatitude
    {
        /// <summary>
        ///     暴力解法，
        ///     但是有部分的效能耗損在重複的資料比對上，10000筆資料大約2735~2780ms
        ///     EX 如果今天陣列長度為100，
        ///     比對道地50筆資料的時候，前面的0~50是可以不用重複比較的，但是51後需要從第一筆開始比對。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum_暴力解(int[] nums, int target)
        {
            foreach (var eOne in nums.Select((value, i) => new {i, value}))
            {
                foreach (var eTwo in nums.Select((value, i) => new {i, value}))
                {
                    if (eOne.i == eTwo.i || target != (eOne.value + eTwo.value)) continue;
                    //  Console.WriteLine($"index  : One : {eOne.i}, Two : {eTwo.i}");
                    //  Console.WriteLine($"target : {target}, One : {eOne.value}, Two : {eTwo.value}");
                    //  Console.WriteLine($"Answer : One : {eOne.i}, Two : {eTwo.i}");
                    return new int[] {eOne.i, eTwo.i};
                }
            }

            return null;
        }
    }
}