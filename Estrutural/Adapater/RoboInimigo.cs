using System;

namespace Adapter
{
    //adaptee é a classe que vai ser adaptada. 
    public class RoboInimigo
    {
        Random gerador = new Random();

        public void EsmagarComMaos()
        {
            var danoAtaque = gerador.Next(10) + 1;

            Console.WriteLine($"O robo inimigou casou {danoAtaque} com o ataque esmagar com as maos.");
        }

        public void AndarFrente()
        {
            var movimento = gerador.Next(10) + 1;

            Console.WriteLine($"O robo inimigou andou {movimento} ");
        }

        public void ReagirContraHumano(string piloto)
        {
            Console.WriteLine($"Robo inimigo vai contra {piloto}");
        }
    }
}
