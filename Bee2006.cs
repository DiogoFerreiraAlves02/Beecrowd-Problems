using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n=int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int correctAnswers=0;
            for(int i=0; i<inputs.Length;i++){
                if(int.Parse(inputs[i]) == n) correctAnswers++;
            }
            Console.WriteLine(correctAnswers);
        }   
    }   
} 
