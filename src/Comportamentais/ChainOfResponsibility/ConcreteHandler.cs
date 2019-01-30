using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ConcreteHandler : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
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
