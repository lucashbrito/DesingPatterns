using System;

namespace Composite
{
    class Folha : Componente
    {

        public Folha(string nome) : base(nome)
        {

        }

        public override void Adicionar(Componente componente)
        {
            Console.WriteLine("não é possivel add a folha");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine($"{profundidade} - {_nome}");
        }

        public override void Remover(Componente componente)
        {
            Console.WriteLine("não é possivel remover a folha");
        }
    }
}
