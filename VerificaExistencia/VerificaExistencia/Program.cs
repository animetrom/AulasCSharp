using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaExistencia
{
    class Program
    {
        static void Main(string[] args)
        {

            String texto = "Olá amigos do Senac Vila Prudente";


            // TRABALHANDO COM O COMANDO StartsWith
            Console.WriteLine("Veiricando se temos a palavra no começo do texto: " + texto.StartsWith("Olá"));

            // TRABALHANDO COM O COMANDO EndsWith
            Console.WriteLine("Veiricando se temos a palavra no final do texto: " + texto.EndsWith("!"));

            // TRABALHANDO COM O COMANDO Contains
            Console.WriteLine("Veiricando se o texto contém: " + texto.Contains("!"));

            Console.ReadKey();
        }
    }
}
