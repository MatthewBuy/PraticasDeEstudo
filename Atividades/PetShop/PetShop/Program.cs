using System;
using System.Collections.Generic;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] raças = { "Beagle", "Bulldog", "Golden Retriever", "Yorkshire Terrier", };
            string[] tamanhos = { "Grande", "Médio", "Pequeno"};
            string escolhaR;
            string escolhaT;

            int valor = 0;
          

            Console.WriteLine("*----------------------------*");
            foreach (var raça in raças)
            {
                Console.WriteLine(raça);
            }
            Console.WriteLine("*----------------------------*");
            Console.WriteLine("Escreva qual é a raça do seu pet");
            escolhaR = Convert.ToString(Console.ReadLine());
            Console.WriteLine("*----------------------------*");
            foreach (var tamanho in tamanhos)
            {
                Console.WriteLine(tamanho);
            }
            Console.WriteLine("*----------------------------*");
            Console.WriteLine("Escreva qual é o tamanho do seu pet");
            escolhaT = Convert.ToString(Console.ReadLine());

            switch (escolhaR)
            {
                case "Beagle":
                case "Bulldog":
                case "Yorkshire Terrier":
                    valor += 15;
                    break;

                default:
                    valor += 20;
                    break;
            }

            switch (escolhaT)
            {
                case"Grande":
                    valor += 30;
                    break;

                case "Médio":
                    valor += 20;
                    break;

                case "Pequeno":
                    valor += 10;
                    break;

                default:
                    break;
            }

            Console.WriteLine($"O preço para dar banho em seu pet é de: R${valor} reais");

        }
    }
}
