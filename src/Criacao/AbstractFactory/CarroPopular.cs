namespace AbstractFactory
{
    public class CarroPopular : CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new RodaSimples();
        }

        public override Som MontarSom()
        {
            return new CdPlayer();
        }
    }
}
