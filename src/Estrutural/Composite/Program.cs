namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var compoSite = new CompoSite("Summary");

            compoSite.Adicionar(new Folha("Cap 1 "));
            compoSite.Adicionar(new Folha("c#   ... pag 1"));
            compoSite.Adicionar(new Folha(".dot ... pag2"));

            var compositeX = new CompoSite("Cap2");
            compositeX.Adicionar(new Folha("c#   ... pag3"));
            compositeX.Adicionar(new Folha(".dot ... pag4"));

            compoSite.Adicionar(compositeX);
            compoSite.Adicionar(new Folha("net  ... pag5"));

            var folha = new Folha("cel ... pag6");

            compoSite.Adicionar(folha);

            compoSite.Mostrar(1);
        }
    }
}
