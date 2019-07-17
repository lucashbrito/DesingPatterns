using System;

namespace Decorator
{
    public class Livro : ItemBiblioteca
    {
        public string Autor { get; set; }

        public string Titulo { get; set; }

        public Livro(string autor, string titulo, int numeroCopias)
        {
            Autor = autor;
            Titulo = titulo;
            NumeroCopias = numeroCopias;
        }
        public override void Exibe()
        {
            Console.WriteLine("Livro");
            Console.WriteLine($"Autor: {Autor}, Titulo: {Titulo}, numero de copias: {NumeroCopias}");
        }
    }
}
