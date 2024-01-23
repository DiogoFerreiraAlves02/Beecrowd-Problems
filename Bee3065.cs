using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int testNr = 1;
            while(int.Parse(Console.ReadLine())!=0){
                string expression = Console.ReadLine();
                List<int> numbers = new List<int>();
                List<char> operations = new List<char>();

                for(int i=0;i<expression.Length;i++){
                    if(i+2<=expression.Length-1){
                        if(Char.IsDigit(expression[i]) && Char.IsDigit(expression[i+1]) && Char.IsDigit(expression[i+2])){
                            numbers.Add(int.Parse(expression[i].ToString() + expression[i+1].ToString() + expression[i+2].ToString()));
                            i+=2;
                        }
                        else if(Char.IsDigit(expression[i]) && Char.IsDigit(expression[i+1])){
                            numbers.Add(int.Parse(expression[i].ToString() + expression[i+1].ToString()));
                            i++;
                        }
                        else if(Char.IsDigit(expression[i])){
                            numbers.Add(int.Parse(expression[i].ToString()));
                        }
                        else operations.Add(expression[i]);
                    }
                    else if(i+1<=expression.Length-1){
                        if(Char.IsDigit(expression[i]) && Char.IsDigit(expression[i+1])){
                            numbers.Add(int.Parse(expression[i].ToString() + expression[i+1].ToString()));
                            i++;
                        }
                        else if(Char.IsDigit(expression[i])){
                            numbers.Add(int.Parse(expression[i].ToString()));
                        }
                        else operations.Add(expression[i]);
                    }
                    else if(Char.IsDigit(expression[i])){
                        numbers.Add(int.Parse(expression[i].ToString()));
                    }
                    else operations.Add(expression[i]);
                }

                int total = 0;
                for(int i=0;i<numbers.Count;i++){
                    if(i==0) total = numbers[i];
                    else{
                        if(operations[i-1] == '+') total += numbers[i];
                        else total -= numbers[i];
                    }
                }

                Console.WriteLine($"Teste {testNr}\n{total}\n");
                testNr++;
            }
        }
    }   
} 

