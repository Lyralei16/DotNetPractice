using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        // Given number of people and numbers
        Dictionary<string, string> dict = new Dictionary<string, string>();

        int n = Convert.ToInt32(Console.ReadLine());
        
       
        while (n > 0){

            string input = Console.ReadLine();
            string[] splitted = input.Split(' ');
            if (splitted.Length > 1){
                dict.Add(splitted[0], splitted[1]);
            }
            else {
                dict.Add(splitted[0], "Not Found");
            }
            n--;
        }
        
        string query = ""; 

        do {
            
            query = Console.ReadLine();
        
            if( query != null){ // query != null; !string.IsNullOrEmpty(query)

                if (dict.ContainsKey(query)){
                Console.WriteLine(query + "=" + dict[query]);
                }
                else{
                Console.WriteLine("Not found");
                }
            }
        } while (!string.IsNullOrEmpty(query));
        

        




      /*   int n = Convert.ToInt32(Console.ReadLine());
        string[] currentLine = new string
        Dictionary<string, string> dict;
        

        for (int i = 0; i < n; i++){
            string name = Console.ReadLine();
            int number = Console.ReadLine();
        } */
    }
   /*  static void addContacts( string name, int number){
        if(!dict.ContainsKey(number)){
            dict[number] = "Not found";
        }
        else{
            dict.Add(name, number);
        }
    } */    
}

