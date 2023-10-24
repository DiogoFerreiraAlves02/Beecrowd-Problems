using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int money = int.Parse(Console.ReadLine());
            int[] banknotes = new int[7] {100,50,20,10,5,2,1};
            Console.WriteLine(money);
    
           for(int i=0; i< banknotes.Length; i++){
            Console.WriteLine($"{money/banknotes[i]} nota(s) de R$ {banknotes[i]},00");
            money = money % banknotes[i];
           }      
        }
    }   
} 