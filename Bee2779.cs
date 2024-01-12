using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            List<int> cardsOwned = new List<int>();
            int X;

            for(int i=0;i<M;i++){
                X = int.Parse(Console.ReadLine());
                if(!cardsOwned.Contains(X)){
                    cardsOwned.Add(X);
                    N--;
                }
            }
            
            Console.WriteLine(N);
        }
    }   
} 

