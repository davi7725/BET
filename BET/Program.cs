﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BET
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            string text = "+;"+
                          "/;" + 
                          "a;" + 
                          "null;" + 
                          "null;" + 
                          "b;" + 
                          "null;" + 
                          "null;" + 
                          "*;" + 
                          "-;" + 
                          "c;" + 
                          "null;" + 
                          "null;" + 
                          "d;" +
                          "null;" + 
                          "null;" + 
                          "e;" + 
                          "null;" + 
                          "null";
            string[] instructions = text.Split(';');
            BET tree = new BET(instructions);

            tree.Insert(instructions);
            Console.WriteLine(tree);

            Console.ReadKey();


        }

        
    }
}
