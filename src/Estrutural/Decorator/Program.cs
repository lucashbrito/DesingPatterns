using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var livro = new Livro("lucas", "mete um leao por dia", 100);
            livro.Exibe();

            var video = new Video("lucas", "mete um leao por ano", 123, 240);
            video.Exibe();

            Console.WriteLine("emprestando um video");
            Emprestado emprestado = new Emprestado(video);

            emprestado.EmprestarItem("Joao");
            emprestado.EmprestarItem("Maria");
            emprestado.EmprestarItem("Jose");

            emprestado.Exibe();

            Console.WriteLine("Devolvendo um video");

            emprestado.DevolverItem("Joao");
            emprestado.DevolverItem("Maria");

            emprestado.Exibe();




            Console.ReadKey()




        }
    }
}
