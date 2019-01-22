using System;

namespace Facade
{
    public class Facade
    {
        private SubSistemaUm _SubSistemaUm = new SubSistemaUm();
        private SubSistemaDois _SubSistemaDois = new SubSistemaDois();
        private SubSistemaTres _SubSistemaTres = new SubSistemaTres();

        public Facade()
        {
            _SubSistemaUm = new SubSistemaUm();
            _SubSistemaDois = new SubSistemaDois();
            _SubSistemaTres = new SubSistemaTres();
        }

        public void MetodoA()
        {
            Console.WriteLine("\n MetodoA() ---------------");
            _SubSistemaDois.MetodoDois();
            _SubSistemaTres.MetodoTres();
        }

        public void MetodoB()
        {
            Console.WriteLine("\n MetodoB() ---------------");
            _SubSistemaUm.MetodoUm();
            _SubSistemaTres.MetodoTres();
        }

    }
}
