using System.Collections.Generic;

namespace Visitor
{
    public  class Objectestructure
    {
        private List<Element>_elements= new List<Element>();

        public void Anexar(Element element)
        {
            _elements.Add(element);
        }

        public void Desanexar(Element element)
        {
            _elements.Remove(element);
        }

        public void Accpet(Visitor  visitor)
        {
            foreach (var element in _elements)
            {
                element.Accet(visitor);
            }
        }
    }
}
