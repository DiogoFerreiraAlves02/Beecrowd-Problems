using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] scores = Console.ReadLine().Split(' ');
            double[] weights = {2,3,4,1};
            double sum = 0.0;
            for(int i = 0; i < scores.Length; i++){
                sum = sum +(double.Parse(scores[i])*weights[i]);
            }
            double avg = sum/10;

            Console.WriteLine($"Media: {string.Format("{0:0.0}", Math.Round(avg, 1))}");
            
            if(avg >= 7.0) Console.WriteLine("Aluno aprovado.");
            else if(avg >= 5.0) {
                Console.WriteLine("Aluno em exame.");
                double examScore = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + string.Format("{0:0.0}", examScore));
                Console.WriteLine($"Aluno {((avg+examScore)/2 >= 5.0 ? "aprovado": "reprovado")}.");
                Console.WriteLine("Media final: " + string.Format("{0:0.0}", Math.Round(((avg + examScore) / 2.0),1)));
            }
            else Console.WriteLine("Aluno reprovado.");
              
        }
    }   
} 