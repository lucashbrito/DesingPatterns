using System;

namespace Mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(IChatMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{_name} envia: {message}");
            _mediator.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{_name} recebe: {message}");
        }
    }
}