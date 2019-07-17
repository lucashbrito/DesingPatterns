using System;
using System.Collections.Generic;

namespace Strategy
{
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);

            foreach (var item in _list)
            {
                Console.WriteLine($"Itens {item}");
            }

            Console.Read();
        }
    }
}
