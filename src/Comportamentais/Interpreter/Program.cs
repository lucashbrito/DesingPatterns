using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "XLDCXXL";

            var context = new Context(roman);

            var expressions = new List<Expression>
            {
                new DozensExpression(), new HundredExpression(), new ManyExpression()
            };

            foreach (var expression in expressions)
            {
                expression.Interpreter(context);
            }

            System.Console.WriteLine($"{roman}, {context.Output}");

            System.Console.ReadKey();
        }
    }
}
