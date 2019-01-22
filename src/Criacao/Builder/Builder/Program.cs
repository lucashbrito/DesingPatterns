using System;

namespace Builder
{
    public static class Program
    {
         static void Main(string[] args)
        {
            var fabricante = new Fabricante();

            ICelular icelular = null;

            icelular = new AndroidBuilder();

            fabricante.Construtor(icelular);

            Console.WriteLine($"Celular construido. {icelular.Celular.Nome}");

            icelular = new IphoneBuilder();

            fabricante.Construtor(icelular);

            Console.WriteLine($"Celular construido. {icelular.Celular.Nome}");
        }
    }
}
