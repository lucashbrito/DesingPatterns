namespace AbstractFactory
{
    public class CarroLuxo : CarroFactory
    {
        public override Roda MontarRoda()
        {
           return new RodaLigaLeve();
        }

        public override Som MontarSom()
        {
            return new Bluetooh();
        }
    }
}
