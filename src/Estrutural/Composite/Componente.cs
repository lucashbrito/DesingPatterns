namespace Composite
{
    public abstract class Componente
    {
        protected string _nome;

        public Componente(string nome)
        {
            _nome = nome;
        }

        public abstract void Adicionar(Componente componente);

        public abstract void Remover(Componente componente);

        public abstract void Mostrar(int profundidade);
    }
}
