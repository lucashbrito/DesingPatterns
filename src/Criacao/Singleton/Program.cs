namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            UsandoSingleton();
            NaoUsandoSingleton();
        }

        static void UsandoSingleton()
        {
            Singleton jogador1 = Singleton.GetInstancia;
            jogador1.Mensagem("Jogador 1: esta com a bola");

            Singleton jogador2 = Singleton.GetInstancia;
            jogador2.Mensagem("Jogador 2: Recebeu a bola do jogador 1");

            Singleton jogador3 = Singleton.GetInstancia;
            jogador3.Mensagem("Jogador 3: recebeu a bola do jogador 2 e chutou p gol");

        }

        static void NaoUsandoSingleton()
        {
            SemSingleton jogador1 = SemSingleton.GetInstancia;
            jogador1.Mensagem("Jogador 1: esta com a bola");

            SemSingleton jogador2 = SemSingleton.GetInstancia;
            jogador2.Mensagem("Jogador 2: Recebeu a bola do jogador 1");

            SemSingleton jogador3 = SemSingleton.GetInstancia;
            jogador3.Mensagem("Jogador 3: recebeu a bola do jogador 2 e chutou p gol");

        }
    }
}
