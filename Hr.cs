using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */


        // Assign Variables 

        int arrLength;
        int arr;
        // Collect the input 

        arrLength = int.Parse(Console.In.ReadLine());
        arr = int.Parse(Console.In.ReadLine());
        Mean(arr);
        //Median(arrLength, arr);
        //Mode(arrLength, arr);
        Console.WriteLine(Mean);
    }

   

    void Mean(int arr){
        
        float result = 3;
        int sum;
        /* for (int i = 0; i < arr.Length; i++) {
            sum += arr[i];
        }
        result = sum / arr.Lenght;
        return result; 
            } */

    }
    float Median(int arrLength, int arr)
    {
        return null;
    }

    int Mode(int arrLength, int arr)
    {
        return;
    }
    
}   \

/* 
    dictionary myDiccc = new dictrionary <string, string>

    while there lines to read{
        string str = "xxxx 23412"; // current line
        string[] strArr = str.Split(" "); // Name, Number
        if(strArr.length > 1) myDicc.Add(strArr[0], strArr[1]);
        else myDicc.Add(strArr[0], "");
    }


    dictionary myDiccc = new dictrionary <string, int>
    while there lines to read{
        string str = "xxxx 23412"; // current line
        string[] strArr = str.Split(" "); // Name, Number
        if(strArr.length > 1) myDicc.Add(strArr[0], (int)strArr[1]);
        else myDicc.Add(strArr[0], "");
    }

    string[]currentl = inestddin.readline.Split(" ");
    if(currentl.length > 1) myDicc.Add(currentl[0], (int)currentl[1]);
        else myDicc.Add(currentl[0], "");


 arr = asdas asdas rgeger 4234 fhdfs;


 */
 while (Console.WriteLine() == true){
            string query = "";
            query = Console.ReadLine();
             if (dict.ContainsKey(query)){
                 Console.WriteLine(query + " = " + dict[query]);
             }
             else{
                 Console.WriteLine("Not Found");
             }
        }





