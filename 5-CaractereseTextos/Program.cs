using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaractereseTextos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o Projeto 5 - Caracteres e Textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2020;
            string cursoProgramacao = @"- .NET
- JAVA
- Javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursoProgramacao);
            

            Console.ReadLine();
            
        }
    }
}
