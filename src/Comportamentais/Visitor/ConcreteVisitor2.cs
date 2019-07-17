using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcretElementA(ConcretElementA concretElementA)
        {
            Console.WriteLine($"{concretElementA.GetType().Name} visitado por {this.GetType().Name}");
        }

        public override void VisitConcretElementB(ConcretElementB concretElementB)
        {
            Console.WriteLine($"{concretElementB.GetType().Name} visitado por {this.GetType().Name}");
        }
    }
}
