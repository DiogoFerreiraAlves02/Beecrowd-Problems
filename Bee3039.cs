using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dic = new Dictionary<string, int>(){{"carrinhos", 0},{"bonecas", 0}};
            string[] input = new string[2];

            for(int i=0; i<n;i++){
                input = Console.ReadLine().Split();
                if(input[1] == "F") dic["bonecas"]++;
                else dic["carrinhos"]++;
            }  
                
            foreach(var item in dic) Console.WriteLine($"{item.Value} {item.Key}");
        }
    }   
} 

