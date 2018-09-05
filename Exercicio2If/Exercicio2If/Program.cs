using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2If
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

            if (numero1 > numero2) {
                Console.WriteLine("O número 1 é maior que o número 2.");
            } else if (numero1 < numero2) {
                Console.WriteLine("O número 1 é menor que o número 2.");
            } else {
                Console.WriteLine("Os dois números são iguais.");
            }

            Console.ReadLine();
        }
    }
}
