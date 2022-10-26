using System;
using System;
using System.CodeDom.Compiler;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Globalization;
using System.IO;
using System.IO;
using System.Linq;
using System.Linq;
using System.Reflection;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization;
using System.Text;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;

namespace Hackerrank.com.SimpleArraySum;

public static class Result
{
    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(List<int> ar)
    {
        return 0;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp))
            .ToList();

        int result = Result.simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}