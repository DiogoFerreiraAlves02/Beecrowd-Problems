using System;
using System.Globalization;
using System.Collections.Generic;
namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] d1 = Console.ReadLine().Split(' ');
            int dia1 = int.Parse(d1[1]);
            string[] horario1 = Console.ReadLine().Split(':');
            int h1 = int.Parse(horario1[0]);
            int m1 = int.Parse(horario1[1]);
            int s1 = int.Parse(horario1[2]);
            string[] d2 = Console.ReadLine().Split(' ');
            int dia2 = int.Parse(d2[1]);
            string[] horario2 = Console.ReadLine().Split(':');
            int h2 = int.Parse(horario2[0]);
            int m2 = int.Parse(horario2[1]);
            int s2 = int.Parse(horario2[2]);

            s1 = s2 - s1;
            m1 = m2 - m1;
            h1 = h2 - h1;
            dia1 = dia2 - dia1;
            
            if(s1<0){
                s1+=60;
                m1--;
            }
            if(m1<0){
                m1+=60;
                h1--;
            }
            if(h1<0){
                h1+=24;
                dia1--;
            }
            Console.WriteLine($"{dia1} dia(s)\n{h1} hora(s)\n{m1} minuto(s)\n{s1} segundo(s)");
        }
    }   
} 