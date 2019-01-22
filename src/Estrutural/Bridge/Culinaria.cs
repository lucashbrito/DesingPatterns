namespace Bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return $"Sintonizado no: Culinaria";
        }

        public string Status()
        {
            return $"Você e está assistindo - Receitas fitness";
        }
    }
}
