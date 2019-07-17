namespace Visitor
{
    public class ConcretElementA : Element
    {
        public override void Accet(Visitor visitor)
        {
            visitor.VisitConcretElementA(this);
        }

        public void OperationA() { }
    }
}