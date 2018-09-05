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
            // DECLARANDO VARIÁVEIS DO TIPO INTEIRO
            int nota1, nota2, nota3, nota4, media;

            // PEDINDO VALORES PARA O USUÁRIO
            Console.WriteLine("Digite a primeira nota: "); // IMPRIMINDO INFORMAÇÃO NA TELA PEDINDO O VALOR A SER DIGITADO
            nota1 = int.Parse(Console.ReadLine()); // RECEBENDO VALOR DIGITADO E ARMAZENANDO NA VARIÁVEL nota1

            Console.WriteLine("Digite a segunda nota: "); // IMPRIMINDO INFORMAÇÃO NA TELA PEDINDO O VALOR A SER DIGITADO
            nota2 = int.Parse(Console.ReadLine()); // RECEBENDO VALOR DIGITADO E ARMAZENANDO NA VARIÁVEL nota2

            Console.WriteLine("Digite a terceira nota: "); // IMPRIMINDO INFORMAÇÃO NA TELA PEDINDO O VALOR A SER DIGITADO
            nota3 = int.Parse(Console.ReadLine()); // RECEBENDO VALOR DIGITADO E ARMAZENANDO NA VARIÁVEL nota3

            Console.WriteLine("Digite a quarta nota: "); // IMPRIMINDO INFORMAÇÃO NA TELA PEDINDO O VALOR A SER DIGITADO
            nota4 = int.Parse(Console.ReadLine()); // RECEBENDO VALOR DIGITADO E ARMAZENANDO NA VARIÁVEL nota4

            media = nota1 + nota2 + nota3 + nota4 / 4; // VARIÁVEL media RECEBE VALORES das variáveis nota1, nota2, nota3, nota4 SOMA E DIVIDE PELA QUANTIDADE
            
            // APAGANDO INFORMAÇÕES IMPRIMIDAS A PARTIR DESTE PONTO PARA CIMA
            Console.Clear();

            // IMPRIMINDO VALOR DA MÉDIA RECEBIDA PELO CALCULO REALIZADO A CIMA
            Console.WriteLine("Média: " + media, Console.ForegroundColor = ConsoleColor.Yellow);
            Console.WriteLine("");

            if (media > 7) { // DETERMINA SE O VALOR É MAIOR QUE 7, SE FOR IMPRIME A INFORMAÇÃO NA TELA
                Console.WriteLine("O aluno foi APROVADO!", Console.ForegroundColor = ConsoleColor.Green); // I
            } else if (media >= 5) { // DETERMINA SE O VALOR É MAIOR OU IGUAL A 5, SE FOR IMPRIME A INFORMAÇÃO NA TELA
                Console.WriteLine("O aluno está de RECUPERAÇÃO", Console.ForegroundColor = ConsoleColor.DarkGreen);
            } else { // SE NÃO COINCIDIR NENHUM DOS RESULTADOS, ENTÃO IMPRIME ESTA INFORMAÇÃO NA TELA
                Console.WriteLine("O aluno foi REPROVADO!", Console.ForegroundColor = ConsoleColor.Red);
            }

            // IMPEDE DE FECHAR O SISTEMA
            Console.ReadKey();
        }
    }
}
