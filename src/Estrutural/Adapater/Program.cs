namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo tanqueInimigo = new TanqueInimigo();
            RoboInimigo roboInimigo = new RoboInimigo();

            IAtaqueInimigo roboAdapter = new RoboInimigoAdapter(roboInimigo);

            roboInimigo.AndarFrente();
            roboInimigo.EsmagarComMaos();
            roboInimigo.ReagirContraHumano("robo sem adpater");

            tanqueInimigo.ArmaFogo();
            tanqueInimigo.Movimenta();
            tanqueInimigo.Pilotar("tanque");

            roboAdapter.ArmaFogo();
            roboAdapter.Movimenta();
            roboAdapter.Pilotar("Robo adpater");

        }
    }
}
