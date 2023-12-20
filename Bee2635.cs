using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string[] searched = new string[n];

            for(int i=0;i<n;i++){
                searched[i] = Console.ReadLine();
            }

            int n2 = int.Parse(Console.ReadLine());

            for(int i=0;i<n2;i++){
                string query = Console.ReadLine();
                int suggestions = 0, suggestionSize = 0;

                foreach(string word in searched){
                    try{
                        if(query == word.Substring(0,query.Length)){
                        suggestions++;
                        suggestionSize = Math.Max(suggestionSize,word.Length);
                        }
                    }
                    catch{}
                }

                if(suggestions==0) Console.WriteLine("-1");
                else Console.WriteLine(suggestions + " " + suggestionSize);
            }

        }  
    }   
} 

