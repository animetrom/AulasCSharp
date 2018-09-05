using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoIf
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = 7; // DECLARANDO VARIÁVEL NUM DO TIPO INTEIRO

            // INÍCIO DO COMANDO IF

            if (num > 7) // SE
            {

                Console.WriteLine("O número é maior que 7");

            }
            else if (num < 7) // SENÃO SE
            {

                Console.WriteLine("O número é menor que 7");

            }

            else // SE
            {

                Console.WriteLine("O número é igual a 7");

            }
            // FIM DO COMANDO IF


            // IMPEDINDO DO SISTEMA FINALIZAR
            Console.ReadKey();
        }
    }
}
