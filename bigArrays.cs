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

class Solution {



    static void Main(string[] args) {
        int[][] arr = new int[6][];
       // int sum = 0;


        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                 
        }
        arrHG(arr);

    }
     static int[][] arrHG(int[][] arr){

        int[][] hourGlass = new int[3][];

        for (int i = 0; i < 3; i++){

            for (int j = 0; j <3; j++){
                if( i == 0 && j == 1 || i == 2 && j == 1){
                    hourGlass[i][j] = 0;
                } else
                {
                    hourGlass[i][j] = arr[i][j];
                }
               Console.WriteLine(hourGlass[i][j]);
            } 
        }

        return hourGlass;
    }
    
}
