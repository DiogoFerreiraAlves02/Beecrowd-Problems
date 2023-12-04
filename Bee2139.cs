using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            DateTime natal = new DateTime(2016, 12, 25);
            DateTime dataInserida = DateTime.Now;
            string[] input = new string[2];

            while(true){
                try{
                    input = Console.ReadLine().Split(' ');
                    dataInserida = new DateTime(2016,int.Parse(input[0]),int.Parse(input[1]));
                }
                catch{
                    break;
                }
                var difDatas = natal - dataInserida;

                if(difDatas.Days>1) Console.WriteLine($"Faltam {difDatas.Days} dias para o natal!");
                else if(difDatas.Days==1) Console.WriteLine("E vespera de natal!");
                else if(difDatas.Days==0) Console.WriteLine("E natal!");
                else if(difDatas.Days<0) Console.WriteLine("Ja passou!");
            }


        }   
    }   
} 
