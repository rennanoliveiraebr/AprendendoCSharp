using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string testeLeitura = File.ReadAllText("\\Users\\Rennan Oliveira\\Documents\\texto");

            if (testeLeitura == "1")
            {
                Console.WriteLine("Teste ok");
            }

            Console.Write("'" + testeLeitura + "'");  

            Console.ReadLine();
        }
    }
}
