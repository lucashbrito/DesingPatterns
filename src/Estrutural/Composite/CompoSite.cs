using System;
using System.Collections.Generic;

namespace Composite
{
    public class CompoSite : Componente
    {
        private List<Componente> _componentes;

        public CompoSite(string nome) : base(nome)
        {
            _componentes = new List<Componente>();
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine($"{profundidade} - {_nome}");

            foreach (var item in _componentes)
            {
                item.Mostrar(profundidade + 2);
            }
        }

        public override void Adicionar(Componente componente)
        {
            _componentes.Add(componente);
        }

        public override void Remover(Componente componente)
        {
            _componentes.Remove(componente);
        }
    }
}
