using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3If
{
    class Program
    {
        static void Main(string[] args)
        {

            int nota1, nota2, nota3, nota4, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            nota4 = int.Parse(Console.ReadLine());
            
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.Clear();

            Console.WriteLine("Média: " + media, Console.ForegroundColor = ConsoleColor.Yellow);
            Console.WriteLine("");

            if (media > 7) {
                Console.WriteLine("O aluno foi APROVADO!", Console.ForegroundColor = ConsoleColor.Green);
            } else if (media >= 5) {
                Console.WriteLine("O aluno está de RECUPERAÇÃO", Console.ForegroundColor = ConsoleColor.DarkGreen);
            } else {
                Console.WriteLine("O aluno foi REPROVADO!", Console.ForegroundColor = ConsoleColor.Red);
            }

            Console.ReadKey();
        }
    }
}
