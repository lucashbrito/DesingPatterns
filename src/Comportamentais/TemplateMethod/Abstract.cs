using System;


namespace TemplateMethod
{
    public abstract class Abstract
    {
        public abstract void PrimitivOperation1();

        public abstract void PrimitivOperation2();

        public void TemplateMethod()
        {
            PrimitivOperation1();
            PrimitivOperation2();

            Console.WriteLine("");
        }

    }
}
