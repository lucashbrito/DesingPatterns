using System;

namespace Singleton
{
    public class SemSingleton
    {
        private static SemSingleton instancia;

        public static SemSingleton GetInstancia
        {
            get
            {
                instancia = new SemSingleton();
                Console.WriteLine("Bola em jogo");
                return instancia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
