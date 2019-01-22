namespace Bridge
{
    public class Filme : ICanal
    {
        const string _canal = "Canal de filmes";

        public string Canal()
        {
            return $"Sintonizado no: {_canal}";
        }

        public string Status()
        {
            return $"Você e está assistindo - os vingadores";
        }
    }
}
