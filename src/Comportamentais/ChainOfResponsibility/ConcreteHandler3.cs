using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request > 30)
            {
                Console.WriteLine($"{GetType().Name} handled request {request}");
            }
            else if (_sucessor != null)
            {
                _sucessor.HandleRequest(request);
            }
        }
    }
}
