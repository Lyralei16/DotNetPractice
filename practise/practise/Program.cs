using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int arCount = Convert.ToInt32(Console.ReadLine());
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        //Array.sort(ar);



        Console.WriteLine(mean(ar, arCount));

    }

    static float mean(int[] ar, int arCount)
    {

        int sum = 0;
        for (int i = 0; i < arCount; i++)
        {
            sum = sum + ar[i];

        }
        float result = sum / arCount;
        return result;
    }
    static float median(int[] ar, int arCount)
    {
        
        int i, j;
        for (j = arCount - 1; j > 0; j--)
        {
            for (i = 0; i < j; i++)
            {
                if (ar[i] > ar[i + 1])
                {
                    exchange(ar, i, i + 1);
                }
            }
        }
        int result = 0;
        return result; 

    }
}


