using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        int size = n, i, j, aux = size;

        while (aux > 0)
        {
            for (j = aux - 1; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (i = (size - aux + 1); i > 0; i--)
            {
                Console.Write("#");
            }
            Console.Write("\n");
            aux--;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = 6;

        Result.staircase(n);
    }
}
