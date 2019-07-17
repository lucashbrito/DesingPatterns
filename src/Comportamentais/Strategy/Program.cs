using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {

            var sortedList= new SortedList();

            sortedList.Add("Jessica");
            sortedList.Add("Julieta");
            sortedList.Add("Joao");
            sortedList.Add("Jose");
            sortedList.Add("Maria");
            sortedList.Add("Lucas");

            sortedList.SetSortStrategy(new QuickSort());
            sortedList.Sort();

            sortedList.SetSortStrategy(new ShellSort());
            sortedList.Sort();

            sortedList.SetSortStrategy(new MergeSort());
            sortedList.Sort();

            Console.Read();

        }
    }
}
