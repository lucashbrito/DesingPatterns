namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler _sucessor;

        public void SetSucessor(Handler sucessor)
        {
            _sucessor = sucessor;
        }

        public abstract void HandleRequest(int request);
    }
}
