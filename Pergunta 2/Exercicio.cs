using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pergunta_2
{
    public class Exercicio
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double n3;
            int codigo;
            char response;
            var calculo = new Calculo();

            Console.WriteLine("Bem-vindo caro aluno, gostaria de saber sua média ponderada? (S) / (N)");
            response = Console.ReadKey().KeyChar;

            while (response == 's' || response == 'S')
            {
                Console.Clear();
                Console.WriteLine("Por favor, digite o código do aluno");
                codigo = int.Parse(Console.ReadLine());
                if (codigo <= 0) {
                    Console.WriteLine("Código inválido");
                    response = 'n';
                }
                Console.WriteLine("Aluno com o código " + codigo + " foi encontrado com sucesso");
                Console.WriteLine("Agora por favor, digite a sua primeira nota ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Agora por favor, digite a sua segunda nota ");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Agora por favor, digite a sua terceira nota ");
                n3 = int.Parse(Console.ReadLine());

                var result = calculo.Calcular(n1, n2, n3);

                if (result < 6) {
                    Console.WriteLine("O aluno " + codigo + " com as seguintes notas " + n1 + " " +n2+ " " + n3+ " possui a média ponderada de " +result.ToString("N2")+ " sendo assim, ele está REPROVADO, pois a média " +
                        "mínima para aprovação é de 6 .");
                }
                else
                {
                    Console.WriteLine("O aluno " + codigo + " com as seguintes notas " + n1 + " " + n2 + " " + n3 + " possui a média ponderada de " + result + " sendo assim, ele está APROVADO .");
                }
                Console.WriteLine("Gostaria de consultar a média novamente?  (S) / (N)");
                response = Console.ReadKey().KeyChar;
                //Console.Clear() ;
            }
            Console.Clear();
            Console.WriteLine("Muito obrigado por usar nossa consulta de média, e volte sempre .");
        }
    }
}
