﻿using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factory = new FactoryMethod();

            Console.WriteLine("Liu kang | SubZero | Scorpion");

            var escolha = Console.ReadLine();

            var personagem = factory.EscolherPersonagem(escolha);

            Console.WriteLine($"vc vai jogar com..");

            personagem.Escolhido();
        }
    }
}
