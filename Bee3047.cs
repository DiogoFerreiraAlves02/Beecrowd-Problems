using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int monicaAge = int.Parse(Console.ReadLine());
            int firstSonAge = int.Parse(Console.ReadLine());
            int secondSonAge = int.Parse(Console.ReadLine());
            int thirdSonAge = monicaAge - (firstSonAge+secondSonAge);
            Console.WriteLine(firstSonAge>secondSonAge && firstSonAge>thirdSonAge ? firstSonAge : secondSonAge > firstSonAge && secondSonAge > thirdSonAge ? secondSonAge : thirdSonAge); 
        }
    }   
} 

