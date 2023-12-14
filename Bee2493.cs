using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){   
            
            int t, qtd, total;
            string input, food;
            var foodsVitamin = new Dictionary<string, int>(){
                {"suco de laranja", 120},
                {"morango fresco", 85},
                {"mamao", 85},
                {"goiaba vermelha", 70},
                {"manga", 56},
                {"laranja", 50},
                {"brocolis", 34},
            };

            while((t = int.Parse(Console.ReadLine())) != 0){
                total=0;
                for(int i = 0; i<t; i++){
                    input = Console.ReadLine();
                    qtd = int.Parse(input.Substring(0,2));
                    food = input.Substring(2);
                    total += foodsVitamin[food.TrimStart().TrimEnd()] * qtd;
                }

                if(total >=110 && total <= 130) Console.WriteLine(total+" mg");
                else if(total < 110) Console.WriteLine("Mais "+ (110-total) + " mg");
                else Console.WriteLine("Menos "+ (total-130) + " mg");
            }
        }   
    }   
} 

