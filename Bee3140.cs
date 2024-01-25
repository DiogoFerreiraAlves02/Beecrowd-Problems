using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            List<string> list = new List<string>();
            string line;
            bool flag = false;
            while(true){
                try{
                    line = Console.ReadLine();
                    if(String.IsNullOrEmpty(line)) break;
                }
                catch{break;}
                
                if(line.Contains("</body>")) flag = false;
                if(flag) list.Add(line);
                if(line.Contains("<body>")) flag = true;
            }   

            foreach(string l in list) Console.WriteLine(l);
        }
    }   
} 

