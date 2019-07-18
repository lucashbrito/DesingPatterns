using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaFlyweight fabrica = new FabricaFlyweight();

            string cor = string.Empty;
            Tartaruga tartaruga = null;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Qual tartaruga enviar para tela:");
                cor = Console.ReadLine();

                tartaruga = fabrica.GeTartaruga(cor);

                tartaruga.Mostra(cor);

            }
        }
    }
}
