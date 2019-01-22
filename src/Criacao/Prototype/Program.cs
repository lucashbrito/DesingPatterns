using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionarioPermanente = new FuncionarioPermanente
            {
                Nome = "lucas",
                Idade = 25,
                Tipo = "GP"
            };

            var funcionarioPermanenteClone = (FuncionarioPermanente)funcionarioPermanente.Clone();
            funcionarioPermanenteClone.Nome = "Brito";
            funcionarioPermanenteClone.Idade = 39;


            Console.WriteLine($"Detalhe do funcionario permanente {funcionarioPermanente.Nome}, {funcionarioPermanente.Idade}, {funcionarioPermanente.Tipo}. ");
            Console.WriteLine($"Detalhe do funcionario permanente Clone{funcionarioPermanenteClone.Nome}, {funcionarioPermanenteClone.Idade}, {funcionarioPermanente.Tipo}. ");
        }
    }
}
