using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FomularioTabuada
{
    class Program
    {
        static void Main(string[] args)
        {

            int formula, contador, numero;

            Console.Write("Digite o Numero para Obter a Tabuada: ");
            numero = int.Parse(Console.ReadLine());

            for (contador = 1; contador <= 10; ++contador)
            {
                formula = numero * contador;
                Console.WriteLine(numero + " X " + contador + " = " + formula);
            }


            // FUNÇÃO FOR SENDO UTILIZADA PARA FAZER UMA VERIFICAÇÃO E APRESENTAR OS NÚMEROS PARES EM UM INTERVALO DE 0 ATÉ 100
            Console.WriteLine();
            Console.WriteLine("Para saber os números pares no intervalo de 0 até 100");
            for (contador = 0; contador <= 100; contador += 2)
            {

                Console.WriteLine("O intervalo contém: " + contador);

            }

            // FUNÇÃO FOR SENDO UTILIZADA PARA FAZER UMA VERIFICAÇÃO E APRESENTAR OS NÚMEROS IMPARES EM UM INTERVALO DE 0 ATÉ 100
            Console.WriteLine();
            Console.WriteLine("Para saber os números ímapares no intervalo de 0 até 100");
            for (contador = 1; contador <= 100; contador += 2)
            {

                Console.WriteLine("O intervalo contém: " + contador);


            }

            Console.ReadLine();

        }
    }
}
