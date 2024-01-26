using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            List<string> fruits = new List<string>();
            List<string> lines = new List<string>();

            for(int i = 0; i < n; i++){
                fruits.Add(Console.ReadLine().ToLower());
            }

            for(int i = 0; i < m; i++){
                lines.Add(Console.ReadLine().ToLower());
            }

            for(int i = 0; i < n; i++){
                bool flag = false;
                for(int j=0;j<m;j++){
                    if(lines[j].Contains(fruits[i]) || lines[j].Contains(ReverseString(fruits[i]))){
                        flag = true;
                        continue;
                    }
                }
                Console.WriteLine(flag ? $"Sheldon come a fruta {fruits[i]}" : $"Sheldon detesta a fruta {fruits[i]}");
            }
        }
        public static string ReverseString(string s){
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }   
} 