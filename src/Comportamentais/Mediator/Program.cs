using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediador = new MediadorConcreto();

            IColega colega;

             colega = new ColegaConcreto1(mediador);
            var colega2 = new ColegaConcreto2(mediador);

            mediador.ColegaConcreto1 = colega;
            mediador.ColegaConcreto2 = colega2;

            colega2.Enviar("Colega 2 enviando um Oi");
            colega.Enviar("Colega 1 enviando um Oi colega 2");

            Console.ReadLine();
        }
    }
}
