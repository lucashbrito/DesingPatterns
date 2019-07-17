using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitConcretElementA(ConcretElementA concretElementA);
        public abstract void VisitConcretElementB(ConcretElementB concretElementA);
    }
}
