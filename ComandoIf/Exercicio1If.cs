using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioIf
{
    class Program
    {
        static void Main(string[] args)
        {

            // DECLARANDO VARIÁVEIS DO TIPO STRING E FLOAT
            string valorPoupancaTexto;
            float valorPoupanca;

            // PEDINDO VALOR A SER ARMAZENADO
            Console.WriteLine("Digite o valor que você possui na sua conta: "); // IMPRIME A INFORMAÇÃO NA TELA PEDINDO O VALOR QUE O USUÁRIO DEVE DIGITAR
            valorPoupancaTexto = Console.ReadLine(); // VARIÁVEL valorPoupancaTexto RECEBE O VALOR DIGITADO PELO USUÁRIO
            valorPoupanca = float.Parse(valorPoupancaTexto);

            // APAGANDO INFORMAÇÕES IMPRIMIDAS A PARTIR DESTE PONTO PARA CIMA
            Console.Clear();

            // INÍCIO DO COMANDO IF
            if (valorPoupanca > 10000) { // DETERMINA O VALOR SE É MAIOR QUE 10000, SE FOR IMPRIME A INFORMAÇÃO NA TELA
                Console.WriteLine("Você é um cliente VIP, dessa maneira possui taxas especiais!"); // INFORMAÇÃO A SER IMPRIMIDA SE O RESULTADO FOR O ESPERADO
            } else if ( valorPoupanca > 50000 ) { // DETERMINA O VALOR SE É MAIOR QUE 50000, SE FOR IMPRIME A INFORMAÇÃO NA TELA
                Console.WriteLine("Você é um cliente ESPECIAL, com taxa de juros de 0,2% a.a."); // INFORMAÇÃO A SER IMPRIMIDA SE O RESULTADOR FOR O ESPERADO
            } else { // SE O RESULTADO NÃO FOR O ESPERADO, IMPRIME ESTA INFORMAÇÃO NA TELA
                Console.WriteLine("Você é um cliente Especial, mas as suas taxas são normais!"); // INFORMAÇÃO A SER IMPRIMIDA SE O RESULTADO NÃO FOR O ESPERADO
            } // FIM DO COMANDO IF

            // IMPEDINDO DE FECHAR O SISTEMA
            Console.ReadKey();
        }
    }
}
