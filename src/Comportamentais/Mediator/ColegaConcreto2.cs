using System;

namespace Mediator
{
    internal class ColegaConcreto2 : Colega, IColega
    {
        public ColegaConcreto2(Mediador mediador) : base(mediador)
        {
        }
        public  void Enviar(string mensage)
        {
            _mediador.Enviar(mensage, this);
        }
        public  void Notificar(string mensagem)
        {
            Console.WriteLine($"Mensagem do Colega 1: {mensagem}");
        }
    }
}