using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            decimal money = decimal.Parse(Console.ReadLine());
            int[] banknotes = new int[6] {100,50,20,10,5,2};
            decimal[] coins = new decimal[6] {1.00m, 0.50m, 0.25m,0.10m,0.05m,0.01m};
            
            money = Math.Abs(money);
            Console.WriteLine("NOTAS:");
            for(int i=0; i< banknotes.Length; i++){
                Console.WriteLine($"{(int)(money/banknotes[i])} nota(s) de R$ {banknotes[i]}.00");
                money = money % banknotes[i];
            }   
            Console.WriteLine("MOEDAS:");
            for(int i=0; i< coins.Length; i++){
                Console.WriteLine($"{(int)(money/coins[i])} moeda(s) de R$ {string.Format("{0:0.00}",coins[i])}");
                money = money % coins[i];
            }  
        }
    }   
} 