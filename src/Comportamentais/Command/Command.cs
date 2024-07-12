namespace Command
{
    public abstract class Command
    {
        protected Receiver _receiver;

        public Command(Receiver receiver)
        {
            _receiver = receiver;
        }

        public abstract void Executar();
    }
}
