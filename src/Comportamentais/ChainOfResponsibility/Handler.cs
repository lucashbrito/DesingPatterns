namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler Next;

        public void SetNextHandler(Handler next)
        {
            Next = next;
        }

        public abstract void HandleRequest(int request);
    }
}
