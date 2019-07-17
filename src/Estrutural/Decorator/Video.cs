using System;

namespace Decorator
{
    public class Video : ItemBiblioteca
    {
        public string Diretor { get; set; }

        public string Titulo { get; set; }

        public int MinutosDuracao { get; set; }

        public Video(string diretor, string titulo, int numeroCopias, int minutosDuracao)
        {
            Diretor = diretor;
            Titulo = titulo;
            NumeroCopias = numeroCopias;
            MinutosDuracao = minutosDuracao;
        }
        public override void Exibe()
        {
            Console.WriteLine("Livro");
            Console.WriteLine($"Diretor: {Diretor}," +
                              $" Titulo: {Titulo}," +
                              $" numero de copias: {NumeroCopias}," +
                              $"duracao{MinutosDuracao}");
        }
    }
}
