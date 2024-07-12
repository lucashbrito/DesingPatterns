using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler orderHandler = new OrderHandler();
            Handler paymentHandler = new PaymentHandler();
            Handler sendEmailHandler = new SendEmailHandler();

            orderHandler.SetNextHandler(paymentHandler);
            paymentHandler.SetNextHandler(sendEmailHandler);

            var requests = new[] { 1, 2, 35, 67, 23, 78, 43 };

            foreach (var request in requests)
            {
                orderHandler.HandleRequest(request);
            }

            Console.ReadLine();
        }
    }
}

