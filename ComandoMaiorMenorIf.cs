using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero1, numero2;

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 < numero2)
            {

                Console.WriteLine("O primeiro número é menor que o segundo.");

            }else
            {

                Console.WriteLine("O primeiro número é maior que o segundo.");

            }

            Console.ReadLine();
        }
       
    }
}
