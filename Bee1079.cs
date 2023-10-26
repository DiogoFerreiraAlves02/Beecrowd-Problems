using System;
using System.Globalization;
using System.Collections.Generic;
namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int times = int.Parse(Console.ReadLine());
            double[] weights = {2,3,5};
            double[] results = new double[times];
            double sum = 0.0;

            for(int i = 0; i < times; i++){
                string[] scores = Console.ReadLine().Split(' ');
                sum = 0;
                for(int j = 0; j < scores.Length; j++){
                    sum = sum +(double.Parse(scores[j])*weights[j]);
                }
                results[i] = Math.Round(sum/10,1);
            }
            foreach(var result in results) Console.WriteLine(string.Format("{0:0.0}", result));
            
        }
    }   
} 