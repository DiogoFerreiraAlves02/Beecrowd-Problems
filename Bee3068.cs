using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input1 = new string[4];
            string[] input2 = new string[2];
            int n, total, testNr=1;
            while(true){
                input1 = Console.ReadLine().Split();
                if(input1[0] == "0" && input1[1] == "0" && input1[2] == "0" && input1[3] == "0"){
                    break;
                }
                total = 0;
                n = int.Parse(Console.ReadLine());
                for(int i=0;i<n;i++){
                    input2 = Console.ReadLine().Split();
                    if((int.Parse(input2[0]) >= int.Parse(input1[0]) && int.Parse(input2[0]) <= int.Parse(input1[2])) && ((int.Parse(input2[1]) >= int.Parse(input1[3]) && int.Parse(input2[1]) <= int.Parse(input1[1])))){
                        total++;
                    }
                }
                Console.WriteLine($"Teste {testNr++}\n{total}");
            }
        }
    }   
} 

