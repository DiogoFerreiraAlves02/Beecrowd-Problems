using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double[] A = new double[100];
            double n;

            for(int i = 0; i < A.Length; i++){
                n = double.Parse(Console.ReadLine());
                A[i] = n;
            }   

            for (int i = 0; i < A.Length; i++){
                if(A[i]<=10){
                    Console.WriteLine($"A[{i}] = {string.Format("{0:0.0}", A[i])}");
                }
            }
        }
    }   
} 