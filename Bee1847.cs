using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] answers = Console.ReadLine().Split(' ');
            int a = int.Parse(answers[0]);
            int b = int.Parse(answers[1]);
            int c = int.Parse(answers[2]);
            string face = ":(";

            if(a > b && (b == c || b < c)) face = ":)";
            else if(a < b && (b == c || b > c)) face = ":(";
            else if(a < b && b < c && (b-a > c-b)) face = ":(";
            else if(a < b && b < c && (b-a <= c-b)) face=":)";
            else if(a > b && b > c && (a-b > b-c)) face = ":)";
            else if(a > b && b > c && (a-b <= b-c)) face = ":(";
            else if(a == b && b < c) face = ":)";
            else if(a == b && b > c) face = ":(";
            Console.WriteLine(face);
        }
    }   
} 
