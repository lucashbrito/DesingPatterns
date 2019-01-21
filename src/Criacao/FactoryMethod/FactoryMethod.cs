namespace FactoryMethod
{
    public class FactoryMethod
    {
        public IPersonagem EscolherPersonagem(string personangem)
        {
            switch (personangem)
            {
                case "Liu Kang": return new LiuKen();
                case "Scorpion": return new Scorpion();
                case "Subzero": return new SubZero();
                default: return null;
            }
        }
    }
}
