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
            var resultdays = new Calculo();

            Console.WriteLine("Digite uma data (dd/mm/yyyy): ");
            dateUser = Console.ReadLine();
           
            if (DateTime.TryParse(dateUser, out dataVencimento))
            {
                Console.WriteLine("Por favor, digite a data do pagamento");
                dateUser1 = Console.ReadLine();
                if (DateTime.TryParse(dateUser1, out dataPagamento ))
                {
                    Console.Clear();
                    Console.WriteLine("Agora, digite o valor de sua fatura por gentileza . ");
                    valorBoleto = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    //Console.WriteLine(resultdays.VerificarDias(dataVencimento,dataPagamento));
                    // bool confirma = resultdays.VerificaFeriado(dataPagamento);
                    Console.WriteLine(resultdays.Calcular(valorBoleto,dataVencimento,dataPagamento));

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
