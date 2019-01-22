using System;

namespace Adapter
{
    public class TanqueInimigo : IAtaqueInimigo
    {
        Random gerador = new Random();

        public void ArmaFogo()
        {
            int danoAtaque = gerador.Next(10);

            Console.WriteLine($"Tanque inimigo fez {danoAtaque}.");
        }

        public void Movimenta()
        {
            int movimento = gerador.Next(10);

            Console.WriteLine($"Tanque inimigo andou {movimento}.");
        }

        public void Pilotar(string piloto)
        {
            Console.WriteLine($"{piloto} está no comando do tanque.");
        }
    }
}
