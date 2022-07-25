// Task # 1
// You are given a function which takes an array of integers "seq" and an integer "target". There exist two elements of the array whose sum is equal to the target. You have to return the indices of those elements. You can assume that exactly one solution exists
// [1,9,2,19]  Target = 3, Answer = 0,2

// [2,4]  Target = 6, Answer =0,1

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        int[] seq = new int[] { 1, 9, 2, 19 };
        int target = 3;
        var response = Task1(seq, target);
        Console.WriteLine("Hello World");
        Console.WriteLine(response);
    }

    public static int[] Task1(int[] seq, int target)
    {
        for (int i = 0; i < seq.Length; i++)
        {
            //for (int j = 1; j < seq.Length; j++)
            //{
          var subtraction = target - seq[i]; 
                if (seq[i+1] == subtraction)
                {
                    return new int[] { i, i+1 };
                }
            //}
        }

        return null;
    }
}