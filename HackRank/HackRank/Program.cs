using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackRank
{
    class Program
    {
        #region Define numbers
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 0 && N >= 2 && N <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            if (N % 2 == 0 && N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            if (N % 2 == 0 && N > 20)
            {
                Console.WriteLine("Not Weird");
            }
            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }

        }
        #endregion
        #region Count total cost of your meal
        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            int res = Convert.ToInt32(meal_cost);
            double tip = meal_cost * (tip_percent / 100);
            double tax = meal_cost * (tax_percent / 100);
            Console.WriteLine(tax);
            double TotalCost = meal_cost + tip + tax;

            Console.WriteLine(TotalCost);
            Console.WriteLine(tax);
            Console.WriteLine(tip);
        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
        #endregion

        static void Main1(string[] args)
        {


            #region declaring varibables
            //int i = 4;
            //double d = 4.0;
            //string s = "HackerRank ";

            //// Declare second integer, double, and String variables.
            //int ineg;
            //double doub;
            //string str;

            //// Read and save an integer, double, and String to your variables.
            //ineg = Convert.ToInt32(Console.ReadLine());
            //doub = Convert.ToDouble(Console.ReadLine());
            //str = Console.ReadLine();

            //// Print the sum of both integer variables on a new line.

            //Console.Write(i + ineg);

            //// Print the sum of the double variables on a new line.

            //  Console.WriteLine(d);
            //// Concatenate and print the String variables on a new line
            //// The 's' variable above should be printed first.
            // Console.WriteLine(s + str);
            #endregion
        }
    }
}
