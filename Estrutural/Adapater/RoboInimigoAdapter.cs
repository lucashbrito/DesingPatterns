
namespace Adapter
{
    public class RoboInimigoAdapter : IAtaqueInimigo
    {

        public RoboInimigo Robo { get; set; }

        public RoboInimigoAdapter(RoboInimigo robo)
        {
            Robo = robo;
        }

        public void ArmaFogo()
        {
            Robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            Robo.AndarFrente();
        }

        public void Pilotar(string piloto)
        {
            Robo.ReagirContraHumano(piloto);
        }
    }
}
