using System;

namespace TemplateMethod
{
    class ConcreteClassB : Abstract
    {
        public override void PrimitivOperation1()
        {
            Console.WriteLine("ConcreteClassB . primitive1");
        }

        public override void PrimitivOperation2()
        {
            Console.WriteLine("ConcreteClassB. primitive2");
        }
    }
}
