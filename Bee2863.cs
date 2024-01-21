using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n;
            while(int.TryParse(Console.ReadLine(),out n)){
                List<decimal> numbers = new List<decimal>();
                for(int i = 0; i < n; i++){
                    numbers.Add(decimal.Parse(Console.ReadLine()));
                }
                Console.WriteLine(numbers.Min());
            }
        }
    }   
} 

