
namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        public Celular Celular { get { return celular; } }

        private Celular celular;

        public AndroidBuilder()
        {
            celular = new Celular("Android");
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
            celular.Sistema = "Android 4.5";
        }

        public void BuildTela()
        {
            celular.Tela = "7"; 
        }        
    }
}
