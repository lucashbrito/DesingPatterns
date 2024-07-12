namespace Decorator
{
    public class Decorator : ItemBiblioteca
    {
        protected ItemBiblioteca ItemBiblioteca;

        public Decorator(ItemBiblioteca itemBiblioteca)
        {
            ItemBiblioteca = itemBiblioteca;
        }
        public override void Exibe()
        {
            ItemBiblioteca.Exibe();
        }
    }
}
