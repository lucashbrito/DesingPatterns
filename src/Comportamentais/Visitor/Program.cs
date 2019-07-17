using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
