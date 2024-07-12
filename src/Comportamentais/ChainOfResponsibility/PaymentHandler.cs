using System;

namespace ChainOfResponsibility
{
    class PaymentHandler : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 20)
            {
                Console.WriteLine($"{GetType().Name} handled request {request}");
            }
            else if (Next != null)
            {
                Next.HandleRequest(request);
            }
        }
    }
}
