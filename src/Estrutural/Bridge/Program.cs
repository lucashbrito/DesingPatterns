using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var smarTv = new SmartTv();

            var input = Console.ReadLine();

            switch (input)
            {
                case "filme":
                    smarTv.Canal = new Filme();
                    break;
                case "culinaria":
                    smarTv.Canal = new Culinaria();
                    break;
                case "documentario":
                    smarTv.Canal = new Documentario();
                    break;
                default:
                    break;
            }

            smarTv.CanalSintonizado();
            smarTv.PlayTv();
        }
    }
}
