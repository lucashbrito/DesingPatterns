namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var objectoEstrutucre = new Objectestructure();

            objectoEstrutucre.Anexar(new ConcretElementA());
            objectoEstrutucre.Anexar(new ConcretElementB());

            var visitor1 = new ConcreteVisitor1();
            var visitor2 = new ConcreteVisitor2();

            objectoEstrutucre.Accpet(visitor1);
            objectoEstrutucre.Accpet(visitor2);
        }
    }
}
