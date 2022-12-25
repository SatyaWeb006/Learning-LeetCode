namespace Hackerrank.com.BalancedArray;

public static class Result
{
    /*
     * https://www.hackerrank.com/contests/world-codesprint-11/challenges/balanced-array/problem
     * 
     * Emma has an array  of size  where  is an even number.
     * An array is balanced if the sum of the left half of the array elements is equal to the sum of right half.
     *
     * To balance an array, Emma can add a non-negative integer  ( ) to any array element .
     * Your task is to find the smallest value of  that makes the array balanced.
     *
     * Input Format
     * The first line contains an even integer .
     * The second line contains the  integer elements of the array .
     */

    public static int BalancedArray(List<int> ar)
    {
        var brakePoint = ar.Count / 2;

        var arrayOne = ar.GetRange(0, brakePoint).Sum();
        var arrayTwo = ar.GetRange(brakePoint , brakePoint).Sum();

        var result = Math.Abs(arrayOne - arrayTwo); 
        
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int result = Result.BalancedArray(a.ToList());
        Console.WriteLine(result);
    }
}