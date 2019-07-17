using System;
using System.Collections.Generic;

namespace Decorator
{
    public class Emprestado : Decorator
    {
        protected List<string> _emprestados = new List<string>();

        public Emprestado(ItemBiblioteca itemBiblioteca) : base(itemBiblioteca)
        {
        }

        public void EmprestarItem(string nome)
        {
            _emprestados.Add(nome);
            ItemBiblioteca.NumeroCopias--;
        }

        public void DevolverItem(string nome)
        {
            _emprestados.Remove(nome);
            ItemBiblioteca.NumeroCopias++;
        }

        public override void Exibe()
        {
            base.Exibe();

            foreach (var item in _emprestados)
            {
                Console.WriteLine($"Emprestado {item}");
            }
        }
    }
}
