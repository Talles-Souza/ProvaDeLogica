namespace Pergunta_1
{
    public class Exercicio
    {
        static void Main(string[] args)
        {
            char response;

            Cars cars = new Cars();

            Console.WriteLine("Olá, Bem-vindo a nossa concessionária!");
            Console.WriteLine("Deseja olhar nossos veículos ? (S/N)");
            response = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Clear();

            while (response == 's' || response == 'S')
            {
                Console.WriteLine("Ótima escolha, possuimos diversos veículos, com certeza teremos " +
                    "um que lhe agrade. ");

                Console.WriteLine("Nós possuímos um total de " + cars.totalCars + " carros sendo " +
                    cars.oldcars + " deles abaixo do ano 2000 e " +
                    cars.newcars + " acima do ano 2000");
                Console.WriteLine();
                Console.WriteLine("Deseja olhar quais modelos ?" +
                    "  (1) - Novos  (2) - Antigos");
                int carDecision = int.Parse(Console.ReadLine());
                if (carDecision == 1)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("** ----------------------------------------------------------------------------------------------------------------- **");
                    Console.WriteLine("   Nome : " + cars.newCar[0] + "   Ano : " + cars.newCar[1] + "   Preço : " + cars.newCar[2] + "   Desconto: "+ cars.newCar[3] + "   Total a Pagar : " + cars.newCar[4]);
                    Console.WriteLine("   Nome : " + cars.newCar2[0] + "   Ano : " + cars.newCar2[1] + "   Preço : " + cars.newCar2[2] + "     Desconto: " + cars.newCar2[3] + "     Total a Pagar : " + cars.newCar2[4]);
                    Console.WriteLine("   Nome : " + cars.newCar3[0] + "      Ano : " + cars.newCar3[1] + "   Preço : " + cars.newCar3[2] + "      Desconto: " + cars.newCar3[3] + "     Total a Pagar : " + cars.newCar3[4]);
                    Console.WriteLine("   Nome : " + cars.newCar4[0] + "       Ano : " + cars.newCar4[1] + "   Preço : " + cars.newCar4[2] + "      Desconto: " + cars.newCar4[3] + "     Total a Pagar : " + cars.newCar4[4]);
                    Console.WriteLine("** ----------------------------------------------------------------------------------------------------------------- **");
                }
                else if (carDecision == 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("** ----------------------------------------------------------------------------------------------------------------- **");
                    Console.WriteLine("   Nome : " + cars.oldCar[0] + "       Ano : " + cars.oldCar[1] + "   Preço : " + cars.oldCar[2] + "   Desconto: " + cars.oldCar[3] + "     Total a Pagar : " + cars.oldCar[4]);
                    Console.WriteLine("   Nome : " + cars.oldCar2[0] + "         Ano : " + cars.oldCar2[1] + "   Preço : " + cars.oldCar2[2] + "    Desconto: " + cars.oldCar2[3] + "       Total a Pagar : " + cars.oldCar2[4]);
                    Console.WriteLine("   Nome : " + cars.oldCar3[0] + "    Ano : " + cars.oldCar3[1] + "   Preço : " + cars.oldCar3[2] + "    Desconto: " + cars.oldCar3[3] + "     Total a Pagar : " + cars.oldCar3[4]);
                    Console.WriteLine("   Nome : " + cars.oldCar4[0] + "       Ano : " + cars.oldCar4[1] + "   Preço : " + cars.oldCar4[2] + "     Desconto: " + cars.oldCar4[3] + "     Total a Pagar : " + cars.oldCar4[4]);
                    Console.WriteLine("** ----------------------------------------------------------------------------------------------------------------- **");

                }
                else
                {
                    Console.WriteLine("Opção inexistente - Por favor escolha corretamente os modelos");

                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Deseja olhar novamente os nossos veículos ? (S/N)");
                response = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Muito obrigado por ter vindo e volte sempre.");
        }
    }
}
