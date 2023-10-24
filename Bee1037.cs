using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double x = double.Parse(Console.ReadLine());
            int[,] intervals = {{0,25}, {25,50},{50,75},{75,100}};
            if(x<0 || x>100){
                Console.WriteLine("Fora de intervalo");
            }
            else{
                for(int i=0; i < intervals.Length; i++){
                    if(x >= intervals[i,0] && x <= intervals[i,1]){
                        Console.WriteLine($"Intervalo {(i > 0 ? "(" : "[")}{intervals[i,0]},{intervals[i,1]}]");
                        return;
                    }
                }
            }
        }
    }   
} 