namespace AbstractFactory
{
    public class ExecuteAbstractFactory
    {
        public static Carro MonstarCarro(string tipoCarro)
        {
            CarroFactory carroFactory = null;
            switch (tipoCarro)
            {
                case "luxo":
                    carroFactory = new CarroLuxo();
                    break;
                case "popular":
                    carroFactory = new CarroPopular();
                    break;
            }

            var carro = new Carro
            {
                Som = carroFactory.MontarSom(),
                Roda = carroFactory.MontarRoda()
            };


            return carro;
        }
    }
}
