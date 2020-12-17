using System;

namespace MakeExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog Beagle = new Dog();

            Beagle.Raça = "Beagle";
            Beagle.Idade = 2;
            Beagle.Tamanho = "Pequeno";
           
            Console.WriteLine($"Cachorro da raça {Beagle.Raça.ToLower()}, do tamanho {Beagle.Tamanho.ToLower()} e idade de {Beagle.Idade} anos");
            
            // Exemplo de um if e else em apenas umas linha.
            int x = 5;
            string result = (x < 3) ? "Is greater." : "Is not greater.";
            Console.WriteLine(result);

            

        }
    }
}
