using System.Collections;

namespace LeetCode.com._00051_N_Queens
{
    /// <summary>
    ///     The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other.
    ///     Given an integer n, return all distinct solutions to the n-queens puzzle. You may return the answer in any order.
    ///     Each solution contains a distinct board configuration of the n-queens' placement, where 'Q' and '.' both indicate a queen and an empty space, respectively.
    /// </summary>
    public  class Solution
    {
        /// <summary>
        ///     解題思路 : https://www.notion.so/syuantsai/2a52eed4b34f4e00a1e49e96a66f6963
        /// </summary>
        /// <returns></returns>
        public static IList<IList<string>> SolveNQueens(int n)
        {
            // 1. 使Dictionary來記錄所有可以放的空間。
            // 2. 在每個Queen放下去後刪去被占據掉的點位。
            // 3. 根據每個可以放的地方去餵Q不能放的結果並回傳資料
            // 4. 但有多種可能性，在同一列有兩個可能性的地方使用遞回去分析?
            // 5. 修正為，正確的結果可以直接反過來使用，但該怎麼紀錄使用？
            // 6. 可以在每次檢查殘餘的空見是否足夠放Queen來提升效率。
            return null;
        }
    }
}