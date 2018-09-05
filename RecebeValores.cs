using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RecebeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando Variáveis
            string nome, cidade, endereco, bairro, pais, estado;
            int idade, qntFilhos;
            double salario;
            char sexo;


            // Recebendo Valores

            // Recebendo valor da variável X declarada como string
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            // Recebendo valor da variável Y declarada como int
            // O método int.Parse() é usado para converter
            // uma representação de string de um número em um inteiro.
            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            // Trabalhando com a variável Z - DOUBLE
            Console.Write("Digite seu salário - R$ ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Trabalhando com a variável W - CHAR
            Console.Write("Digite o Sexo (M/F): ");
            sexo = char.Parse(Console.ReadLine());

            Console.Write("Digite a Cidade: ");
            cidade = Console.ReadLine();

            Console.Write("Digite o Endereço: ");
            endereco = Console.ReadLine();

            Console.Write("Digite o Bairro: ");
            bairro = Console.ReadLine();

            Console.Write("Digite o País: ");
            pais = Console.ReadLine();

            Console.Write("Digite a quantidade de filhos: ");
            qntFilhos = int.Parse(Console.ReadLine());

            // Apresentando os valores digitados.
            Console.WriteLine();
            Console.WriteLine("## RESULTADO ##");
            Console.WriteLine();
            Console.WriteLine("O nome digitado foi: " + nome);
            Console.WriteLine("A idade informada foi: " + idade);
            Console.WriteLine("O salário informado foi de R$ " + salario);
            Console.WriteLine("O sexo informado foi: " + sexo);
            Console.WriteLine("O Estado Civil informado foi: " + estado);
            Console.WriteLine("A cidade informada foi: " + cidade);
            Console.WriteLine("O endereço informado foi: " + endereco);
            Console.WriteLine("O bairro informado foi: " + bairro);
            Console.WriteLine("O país informado foi: " + pais);
            Console.WriteLine("A quantidade de filhos informados foram: " + qntFilhos);


            Console.ReadLine();

        }
        
    }
}
