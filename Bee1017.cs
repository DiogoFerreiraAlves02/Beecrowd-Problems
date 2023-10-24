using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int hours = int.Parse(Console.ReadLine());
            int avgSpeed = int.Parse(Console.ReadLine());
           
            Console.WriteLine(string.Format("{0:0.000}", avgSpeed/12.0*hours));            
        }
    }   
} 