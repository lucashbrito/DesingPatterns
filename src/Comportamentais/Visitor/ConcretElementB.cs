namespace Visitor
{
    public class ConcretElementB:Element
    {
        public override void Accet(Visitor visitor)
        {
            visitor.VisitConcretElementB(this);
        }

        public void OperationA() { }
    }
}