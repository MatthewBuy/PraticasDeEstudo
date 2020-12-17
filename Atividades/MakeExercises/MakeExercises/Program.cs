using System;

namespace MakeExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog Beagle = new Dog("Beagle", "Pequeno", 2);

           
            Console.WriteLine($"Cachorro da raça {Beagle.raça.ToLower()}, do tamanho {Beagle.tamanho.ToLower()} e idade de {Beagle.idade} anos");
            
            // Exemplo de um if e else em apenas umas linha.
            int x = 5;
            string result = (x < 3) ? "Is greater." : "Is not greater.";
            Console.WriteLine(result);

            

        }
    }
}
