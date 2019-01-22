namespace Bridge
{
    public class Documentario: ICanal
    {
        public string Canal()
        {
            return $"Sintonizado no: documentario";
        }

        public string Status()
        {
            return $"Você e está assistindo - vida selvagem";
        }
    }
}
