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
            // DECLARANDO VARIÁVEIS DO TIPO TEXTO
            String texto = "Sejam bem-vindos ao Senac Vila Prudente";

            Console.WriteLine(texto);
            
            // USANDO COMANDO ToUpper RESPONSANVEL POR DEIXAR TUDO MAIÚSCULO
            Console.WriteLine(texto.ToUpper());
            
            // USANDO COMANDO ToLower RESPONSANVEL POR DEIXAR TUDO MINÚSCULO
            Console.WriteLine(texto.ToLower());

            Console.ReadKey();

        }
    }
}
