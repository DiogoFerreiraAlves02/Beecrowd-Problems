using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());

            int homeUmbrellas = 0, workUmbrellas = 0, home = 0, work = 0;

            for(int i=0;i<n;i++){
                string[] input = Console.ReadLine().Split();
                if(input[0] == "chuva"){
                    if(home>0) home--;
                    else homeUmbrellas++;
                    work++;
                }

                if(input[1] == "chuva"){
                    if(work>0) work--;
                    else workUmbrellas++;
                    home++;
                }
            }

            Console.WriteLine($"{homeUmbrellas} {workUmbrellas}");
        }
    }   
} 

