using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dic = new Dictionary<string, int>(){{"Hobbit(s)", 0},{"Humano(s)", 0},{"Elfo(s)", 0},{"Anao(oes)", 0},{"Mago(s)", 0}};
            string[] input = new string[2];

            for(int i=0; i<n;i++){
                input = Console.ReadLine().Split();
                if(input[1] == "A") dic["Anao(oes)"]++;
                else if(input[1] == "E") dic["Elfo(s)"]++;
                else if(input[1] == "H") dic["Humano(s)"]++;
                else if(input[1] == "M") dic["Mago(s)"]++;
                else if(input[1] == "X") dic["Hobbit(s)"]++;
            }  
                
            foreach(var item in dic) Console.WriteLine($"{item.Value} {item.Key}");
        }
    }   
} 

