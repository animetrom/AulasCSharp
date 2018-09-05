using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexoMF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis
            string sexo;
            

            // Exibindo texto na tela
            Console.WriteLine("=======================================");
            Console.WriteLine("Digite o sexo (M/F): ");

            // Armazenando valor na variável
            sexo = Console.ReadLine();

            // Determinando valor armazenado
            if (sexo == "M") {

                Console.WriteLine("Seu sexo é Masculino!");
            }
            else
            {

                Console.WriteLine("Se sexo é Feminino.");

            }

            Console.ReadLine();

        }
    }
}
