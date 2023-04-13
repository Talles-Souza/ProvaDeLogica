namespace Pergunta_4
{
    public class Exercicio
    {
        static void Main(string[] args)
        {
           
            DateTime dataVencimento;
            DateTime dataPagamento;
            string dateUser;
            string dateUser1;
            double valorBoleto;
            var resultdays = new Calculo();
            char response;

            Console.WriteLine("Olá, deseja consultar o valor de seu boleto ? (S/N)");
            response = Console.ReadKey().KeyChar;

            while (response == 's' || response == 'S')
            {
                Console.Clear();
                Console.Write("Por favor, digite a data de vencimento do seu boleto no formato (dd/mm/yyyy) : ");
                dateUser = Console.ReadLine();

                if (DateTime.TryParse(dateUser, out dataVencimento))
                {
                    Console.Write("Por favor, digite a data que deseja efetuar o pagamento do seu boleto no formato (dd/mm/yyyy) : ");
                    dateUser1 = Console.ReadLine();
                    if (DateTime.TryParse(dateUser1, out dataPagamento))
                    {
                        var formattedDate = String.Format("{0:dd/MM/yyyy}", dataPagamento);
                        var formattedDate1 = String.Format("{0:dd/MM/yyyy}", dataVencimento);
                        Console.Write("Agora, digite o valor de sua fatura por gentileza : ");
                        valorBoleto = double.Parse(Console.ReadLine());
                        Console.Clear() ;
                        Console.WriteLine("Data Vencimento original : " + formattedDate1);
                        Console.WriteLine("Valor original do boleto : " + valorBoleto);
                        Console.WriteLine("Nova Data Vencimento (Pagamento) : " + formattedDate);
                        Console.WriteLine("Valor do boleto recalculado : " + resultdays.Calcular(valorBoleto, dataVencimento, dataPagamento));
                        Console.WriteLine("Valor total do juros : " + resultdays.valueJuros);
                        Console.WriteLine("Valor total da multa : " + resultdays.valueMulta);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Olá, deseja consultar o valor de seu boleto novamente ? (S/N)");
                        response = Console.ReadKey().KeyChar;
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
            }
            Console.WriteLine("Obrigado e volte sempre");
        }
    }
}
