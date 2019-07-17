using System;

namespace Mediator
{
    internal class ColegaConcreto1 : Colega, IColega
    {
        public ColegaConcreto1(Mediador mediador) : base(mediador)
        {
        }

        public void Enviar(string mensage)
        {
            _mediador.Enviar(mensage, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine($"Mensagem do Colega 2: {mensagem}");
        }
    }
}