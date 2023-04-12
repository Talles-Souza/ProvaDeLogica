using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
                    Console.WriteLine("** ----------------------------------------------------------------------------------------------------------------- **");
                    Console.WriteLine("   Nome : " + cars.newCar[0] + "   Ano : " + cars.newCar[1] + "   Preço : " + cars.newCar[2] + "   Desconto: "+ cars.newCar[3] + "   Total a Pagar : " + cars.newCar[4]);
                    Console.WriteLine("   Nome : " + cars.newCar2[0] + "   Ano : " + cars.newCar2[1] + "   Preço : " + cars.newCar2[2] + "     Desconto: " + cars.newCar2[3] + "     Total a Pagar : " + cars.newCar2[4]);
                    Console.WriteLine("   Nome : " + cars.newCar3[0] + "      Ano : " + cars.newCar3[1] + "   Preço : " + cars.newCar3[2] + "      Desconto: " + cars.newCar3[3] + "     Total a Pagar : " + cars.newCar3[4]);
                    Console.WriteLine("   Nome : " + cars.newCar4[0] + "       Ano : " + cars.newCar4[1] + "   Preço : " + cars.newCar4[2] + "      Desconto: " + cars.newCar4[3] + "     Total a Pagar : " + cars.newCar4[4]);
                    Console.WriteLine("** ----------------------------------------------------------------------------------------------------------------- **");
                }
                else if (carDecision == 2)
                {
                    Console.WriteLine("Antigo");
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
