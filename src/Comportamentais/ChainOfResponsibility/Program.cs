using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSucessor(h2);
            h2.SetSucessor(h3);

            var requests = new[] { 1, 2, 35, 67, 23, 78, 43 };

            foreach (var request in requests)
            {
                h1.HandleRequest(request);
            }

            Console.ReadLine();
        }
    }
}

