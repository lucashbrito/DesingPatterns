using System;

namespace TemplateMethod
{
    class ConcreteClass : Abstract
    {
        public override void PrimitivOperation1()
        {
            Console.WriteLine("ConcreteClass1 . primitive1");
        }

        public override void PrimitivOperation2()
        {
            Console.WriteLine("ConcreteClass1. primitive2");
        }
    }
}
