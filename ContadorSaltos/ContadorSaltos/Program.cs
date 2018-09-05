using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorSaltos
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador;

            Console.WriteLine("Pressione qualquer tecla para começar!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("Para saber saltos de 10 em 10 até 1000");
            for (contador = 0; contador <= 1000; contador += 10)
            {

                Console.WriteLine("O intervalo contém: " + contador);

            }
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("======================================");
            Console.WriteLine("Para saber saltos de 20 em 20 até 1000");
            for (contador = 0; contador <= 1000; contador += 20)
            {

                Console.WriteLine("O intervalo contém: " + contador);

            }
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("Para saber saltos de 50 em 50 até 1000");
            for (contador = 0; contador <= 1000; contador += 50)
            {

                Console.WriteLine("O intervalo contém: " + contador);

            }
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("Para saber saltos de 100 em 100 até 10000");
            for (contador = 0; contador <= 10000; contador += 100)
            {

                Console.WriteLine("O intervalo contém: " + contador);

            }
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("Para saber saltos de 200 em 200 até 10000");
            for (contador = 0; contador <= 10000; contador += 200)
            {

                Console.WriteLine("O intervalo contém: " + contador);

            }
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("Para saber saltos de 500 em 500 até 100000");
            for (contador = 0; contador <= 100000; contador += 500)
            {

                Console.WriteLine("O intervalo contém; " + contador);

            }
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadLine();
            Console.Clear();

            Console.ReadLine();
        }
    }
}
