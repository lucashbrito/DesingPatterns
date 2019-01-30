using System;

namespace ChainOfResponsibility
{
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 20)
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
