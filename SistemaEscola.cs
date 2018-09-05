using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            double media, notaUm, notaDois, notaTres, notaQuatro;
            string nomeDoAluno, nomeDoPai, nomeDaMae;
            char sexoDoAluno;

            // CONFIGURANDO O HEADER DO SISTEMA
            Console.WriteLine("===================================================");
            Console.WriteLine("=============== Sistema da Escola =================");
            Console.WriteLine("===================================================");

            // ARMAZENA OS DADOS
            Console.Write("Digite o nome do Aluno: ");
                nomeDoAluno = Console.ReadLine();

            Console.Write("Digite o sexo do Aluno(M/F): ");
            sexoDoAluno = char.Parse(Console.ReadLine());

            Console.Write("Digite o nome do Pai: ");
            nomeDoPai = Console.ReadLine();

            Console.Write("Digite o nome da Mãe: ");
            nomeDaMae = Console.ReadLine();

            // RECEBENDO AS NOTAS
            Console.WriteLine("Digite a primeira nota: ");
            notaUm = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            notaDois = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            notaTres = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            notaQuatro = double.Parse(Console.ReadLine());
            Console.Write("===================================================");

            // SOMA E ARMAZENA A MÉDIA DAS NOTAS
            media = (notaUm + notaDois + notaTres + notaQuatro) / 4;

            // LIMPA TELA DO CONSOLE
            Console.Clear();

            // IMPRIMINDO OS VALORES NA TELA

            Console.WriteLine("===================================================");
            Console.WriteLine("======= Escola XYZ - Resultados do Aluno ==========");
            Console.WriteLine("===================================================");

            // APRESENTE O NOME DO ALUNO
            Console.WriteLine("O aluno " + nomeDoAluno);
            Console.WriteLine("O aluno teve média: " + media);
            Console.WriteLine(" ");
            Console.WriteLine("Notas do ano: ");
            Console.WriteLine(" ");
            Console.WriteLine("Primeira nota: " + notaUm);
            Console.WriteLine("Segunda nota: " + notaDois);
            Console.WriteLine("Terceira nota: " + notaTres);
            Console.WriteLine("Quarta nota: " + notaQuatro);

            if (media >= 6) {

                Console.WriteLine(nomeDoAluno + ", foi APROVADO!");
                Console.WriteLine("===================================================");
                Console.WriteLine(nomeDoPai + " e " + nomeDaMae + ", continuem com o ótimo trabalho com seu(ua) filho(a)");
                Console.WriteLine("===================================================");

            }
            else
            {
                Console.WriteLine(nomeDoAluno + ", foi REPROVADO!");
                Console.WriteLine(nomeDoPai + " e " + nomeDaMae + ", façam seu(ua) filho(a) estudar mais!!!");
            }

            Console.WriteLine("====================================================");
            Console.WriteLine("== Aperte qualquer tecla para encerrar o sistema! ==");
            Console.WriteLine("====================================================");

            Console.ReadLine();
        }

    }
}
