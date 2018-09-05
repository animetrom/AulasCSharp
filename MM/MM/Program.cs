using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Sejam bem-vindos ao Senac Vila Prudente";

            Console.WriteLine(texto);
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());

            Console.ReadKey();

        }
    }
}
