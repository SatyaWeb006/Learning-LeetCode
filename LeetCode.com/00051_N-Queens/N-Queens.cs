using System.Drawing;

namespace LeetCode.com._00051_N_Queens
{
    /// <summary>
    ///     The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other.
    ///     Given an integer n, return all distinct solutions to the n-queens puzzle. You may return the answer in any order.
    ///     Each solution contains a distinct board configuration of the n-queens' placement, where 'Q' and '.' both indicate a queen and an empty space, respectively.
    /// </summary>
    public class Solution
    {
        /// <summary>
        ///     解題思路 : https://www.notion.so/syuantsai/2a52eed4b34f4e00a1e49e96a66f6963
        /// </summary>
        /// <returns></returns>
        public static IList<IList<string>> SolveNQueens(int n)
        {
            // 1. 使Dictionary來記錄所有可以放的空間。 OK
            // 2. 在每個Queen放下去後刪去被占據掉的點位； 
            //    不需要考慮後面的位置，因為會被前面的Queen卡死。
            // 3. 根據每個可以放的地方去餵Q不能放的結果並回傳資料
            // 4. 但有多種可能性，在同一列有兩個可能性的地方使用遞回去分析?
            // 5. 修正為，正確的結果可以直接反過來使用，但該怎麼紀錄使用？
            // 6. 可以在每次檢查殘餘的空見是否足夠放Queen來提升效率。
            return null;
        }


        /// <summary>
        ///     建立空棋盤
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static Dictionary<string, bool> CreateCheckerBoard(int range)
        {
            var result = new Dictionary<string, bool>();
            for (var row = 1; row <= range; row++)
            {
                for (var col = 1; col <= range; col++)
                {
                    var key = $"{col},{row}";
                    result[key] = true;
                }
            }

            return result;
        }

        /// <summary>
        ///     去除被Queen所封禁的座標
        /// </summary>
        /// <param name="area"></param>
        /// <param name="queen"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static Dictionary<string,bool> AreaFilter(Dictionary<string, bool> area, Dictionary<string, bool> queen)
        {
            var result = area.Except(queen).ToDictionary(x => x.Key, _ => true);
            return result;
        }
        
        
        /// <summary>
        ///     計算出每個皇后所封禁的座標
        /// </summary>
        /// <param name="place"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static Dictionary<string, bool> QueenPlacingExclusionArea(string place, int range)
        {
            var area = place.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (area.Length is > 2 or 0)
            {
                throw new ArgumentOutOfRangeException(nameof(place), "不屬於二維陣列");
            }

            //var key = $"{fCol},{fRow}";
            var colIsNum = int.TryParse(area[0], out var col);
            var rwoIsNum = int.TryParse(area[1], out var row);

            if (!colIsNum || !rwoIsNum)
            {
                throw new ArgumentException("輸入內容無法傳換成數值");
            }

            var result = new Dictionary<string, bool>();
            for (var fRow = 1; fRow <= range; fRow++)
            {
                for (var fCol = 1; fCol <= range; fCol++)
                {
                    var tPoint = new Point(fCol, fRow);
                    if (
                        //  列
                        col == fCol ||
                        //  行
                        row == fRow ||
                        //  右斜
                        IsPointOnLine(  new Point(col, row) ,new Point(col +1, row +1)  ,tPoint) ||
                        //  右斜
                        IsPointOnLine(  new Point(col, row) ,new Point(col -1, row +1)  ,tPoint)
                        
                    )
                    {
                        var key = $"{fCol},{fRow}";
                        result[key] = true;
                    }
                }
            }

            return result;
        }


        /// <summary>
        ///     斜率計算
        /// </summary>
        /// <param name="sPoint"></param>
        /// <param name="ePoint"></param>
        /// <param name="tPoint"></param>
        /// <returns></returns>
        private static bool IsPointOnLine(Point sPoint, Point ePoint, Point tPoint)
        {
            var slope = (ePoint.Y - sPoint.Y) / (ePoint.X - sPoint.X);
            var yIntercept = sPoint.Y - slope * sPoint.X;
            if (tPoint.Y != slope * tPoint.X + yIntercept)
            {
                return false;
            }

            return true;
        }

    }
}