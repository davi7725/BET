using System;
using System.Collections.Generic;
using System.IO;
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

            List<string> listOfLines = new List<string>();
            StreamReader sr = File.OpenText("instructions.txt");

            while(sr.Peek() >= 0)
            {
                listOfLines.Add(sr.ReadLine());
            }

            BET tree = new BET(listOfLines.ToArray());

            Console.WriteLine(tree);

            Console.ReadKey();


        }

        
    }
}
