using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var aggregate = new ConcreteAggregate();

            aggregate[0] = "Item A";
            aggregate[1] = "Item B";
            aggregate[2] = "Item C";
            aggregate[3] = "Item D";

            var iterator = aggregate.CreateIterator();

            Console.WriteLine("interagindo com a colecao:");

            object item = iterator.First();

            while (item != null)
            {
                Console.WriteLine($"Current Item:{iterator.CurrentItem()}");
                item = iterator.Next();
                Console.WriteLine($"Is done:{iterator.IsDone()}");
            }

            iterator.Next();
            Console.WriteLine($"Is done:{iterator.IsDone()}");
            Console.ReadLine();
        }
    }
}
