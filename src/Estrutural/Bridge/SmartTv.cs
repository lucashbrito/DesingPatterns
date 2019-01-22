using System;

namespace Bridge
{
    public class SmartTv
    {
        public ICanal Canal { get; set; }

        public void CanalSintonizado()
        {
            if (Canal != null)
                Console.WriteLine($"Canal atual {Canal.Canal()}");
            Console.WriteLine("Por favor, selecione um canal");
        }

        public void PlayTv()
        {
            if (Canal != null)
                Console.WriteLine($"Canal atual {Canal.Status()}");
            Console.WriteLine("Por favor, selecione um canal");
        }

    }
}
