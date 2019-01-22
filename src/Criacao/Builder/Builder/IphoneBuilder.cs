namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        public Celular Celular { get { return celular; } }

        Celular celular;

        public IphoneBuilder()
        {
            celular = new Celular("Iphone");
        }

        public void BuildBateria()
        {
            celular.Bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            celular.Camera = "15 MP";
        }

        public void BuildSistema()
        {
            celular.Sistema = "Ios 11";
        }

        public void BuildTela()
        {
            celular.Tela = "9";
        }
    }
}
