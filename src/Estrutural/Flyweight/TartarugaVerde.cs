﻿using System;

namespace Flyweight
{
    public class TartarugaVerde : Tartaruga
    {
        public TartarugaVerde()
        {
            condicao = "Tartarua dentro do casco";
            acao = "rodando no chao";
        }
        public override void Mostra(string cor)
        {
            Cor = cor;
            Console.WriteLine($"{condicao}, {acao}, {Cor.ToUpper()}");
        }
    }
}
