using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine($"{seconds/3600}:{(seconds%3600)/60}:{seconds%60}");
        }
    }   
} 