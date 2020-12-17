using System;
using System.Collections.Generic;
using System.Text;

namespace MakeExercises
{
    class Dog
    {
        public string Raça { get; set; }
        public string Tamanho { get; set; }
        public int Idade { get; set; }

        public Dog(string raças, string tamanhos, int idades)
        {
            Raça = raças;
            Tamanho = tamanhos;
            Idade = idades;

        }

    }
}
