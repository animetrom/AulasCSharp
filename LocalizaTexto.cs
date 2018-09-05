using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARANDO VARIÁVEIS DO TIPO TEXTO
            String texto = "Olá amigos, estou muito feliz por estar aqui com vocês!";
            String palavra = "feliz";
            String texto01 = "Silvio Santos Ipsum valendo um milho de reaisammm. Eu no queria perguntar isso publicamente, ma vou perguntar. Carla, voc tem o ensino fundamentauam? Mah ooooee vem pra c. Vem pra c. O arriscam tuduam, valendo um milho de reaisuam. Eu s acreditoammmm.... Vendoammmm. Ha haeeee. Hi hi. Ma vale drreaisam?";
            String palavra01 = "perguntar";

            // CONTANDO A QUANTIDADE DE CARACTERES NAS VARIÁVERIS DECLARADAS
            Console.WriteLine("O tamanho do texto é de: " + texto.Length);
            Console.WriteLine("O tamanho do texto é de: " + texto01.Length);

            Console.ReadLine();
            Console.Clear();

            // LOCALIZANDO UMA PALAVRA INDICADA
            Console.WriteLine("O texto foi localizado na posição: " + texto.IndexOf(palavra));
            Console.WriteLine("O segundo texto foi localizado na posição: " + texto01.IndexOf(palavra01));

            Console.ReadLine();
            Console.Clear();

            // LOCALIZANDO A POSIÇÃO DO ÚLTIMO CARATERE
            Console.WriteLine("O último caractere foi localizado na posição: " + texto.LastIndexOf(palavra));

            // IMPEDINDO FECHAMENTO DO SISTEMA
            Console.ReadLine();
        }
    }
}
