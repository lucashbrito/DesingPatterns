﻿namespace Proxy
{
    public class Proxy : Subject
    {
        private RealSubject realSubject;

        public override void Requisicao()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }

            realSubject.Requisicao();
        }
    }
}
