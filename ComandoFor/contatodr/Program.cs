using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contatodr
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARANDO VARIAVEIS
            double formula, contador, numero;

            // RECEBENDO VALORES
            Console.Write("Digite o número para obter a Tabuada: ");
            numero = double.Parse(Console.ReadLine());


            // COMANDO PARA
            for (contador = 1; contador <= 10000000; ++contador)
            {

                formula = numero * contador;
                Console.WriteLine(numero + " x " + contador + " = " + formula);

            }

            Console.ReadLine();

        }
    }
}
