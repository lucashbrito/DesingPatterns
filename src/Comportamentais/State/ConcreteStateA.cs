namespace State
{
    public class ConcreteStateA : State
    {
        public override void Handle(Contexto contexto)
        {
            contexto.State = new ConcreteStateB();
        }
    }
}