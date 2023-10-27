using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] reads = new string[2];
            int m, n, sum;
            string msg;
            List<String> results = new List<String>();

            while(true){
                sum = 0;
                msg = "";
                reads = Console.ReadLine().Split(' ');
                m = int.Parse(reads[0]);
                n = int.Parse(reads[1]);
                if(m <= 0 || n <= 0 ) break;
                if(n > m){
                    int aux = n;
                    n = m;
                    m = aux;
                }
                for(int i = n; i <= m; i++){
                    msg += (i + " ");
                    sum += i;
                }
                results.Add(msg + "Sum=" + sum);           
            }
            foreach(var result in results) Console.WriteLine(result);
        }
    }   
} 