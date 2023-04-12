using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pergunta_4
{
    public class Exercicio
    {
        static void Main(string[] args)
        {
            //var formattedDate = String.Format("{0:dd/MM/yyyy}",dataPagamento);
            DateTime dataVencimento;
            DateTime dataPagamento;
            string dateUser;
            string dateUser1;
            double valorBoleto;
            double valorBoletoRecalculado;
            var resultdays = new Calculo();

            Console.WriteLine("Digite uma data (dd/mm/yyyy): ");
            dateUser = Console.ReadLine();
           
            if (DateTime.TryParse(dateUser, out dataPagamento))
            {
                Console.WriteLine("Por favor, digite a data do pagamento");
                dateUser1 = Console.ReadLine();
                if (DateTime.TryParse(dateUser1, out dataVencimento))
                {
                    Console.Clear();
                    Console.WriteLine("Agora, digite o valor de sua fatura por gentileza . ");
                    valorBoleto = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    //Console.WriteLine(resultdays.VerificarDias(dataVencimento,dataPagamento));
                    // bool confirma = resultdays.VerificaFeriado(dataPagamento);
               
                    
                }
                else
                {
                    Console.WriteLine("Formato inválido: " + dateUser);
                }
            }
            else
            {
                Console.WriteLine("Formato inválido: " + dateUser);
            }
            Console.WriteLine("Obrigado e volte sempre");
        }
    }
}
