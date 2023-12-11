using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){   
            int n = int.Parse(Console.ReadLine());
            string grade;

            if(n > 85) grade = "A";
            else if(n > 60) grade = "B";
            else if(n > 35) grade = "C";
            else if(n > 0) grade = "D";
            else grade = "E";

            Console.WriteLine(grade);
        }   
    }   
} 

