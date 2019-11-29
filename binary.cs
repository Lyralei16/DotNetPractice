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
        int n = Convert.ToInt32(Console.ReadLine());
        int[] binary = new int[10];
        int i;

         for(i=0; n>0; i++)      
        {      
         binary[i]=n%2;      
         n= n/2;    
        }  

       Console.Write("Binary of the given number= ");      
       for(i=i-1 ;i>=0 ;i--)      
       {      
        Console.Write(binary[i]);      
       }                 

     /*    if (n != 0){
            int part = n % 2;
            //Console.WriteLine(binaryCount(n));
            binary = + part;
            Console.WriteLine(binary);
            
        } */

    }
    /* static int binaryCount(int n){
        
            
        Console.WriteLine(n);
        return part;
    } */
}
