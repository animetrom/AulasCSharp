using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudaCores
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;

            Console.WriteLine("Informe a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ACESSO PERMITIDO!");

            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ACESSO NEGADO!");

            }

            Console.ReadLine();

        }
    }
}
