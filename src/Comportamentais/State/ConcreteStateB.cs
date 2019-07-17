namespace State
{
    public class ConcreteStateB : State
    {
        public override void Handle(Contexto contexto)
        {
            contexto.State = new ConcreteStateA();
        }
    }
}
