namespace Mediator
{
    class MediadorConcreto : Mediador
    {
        private IColega _colega1;
        private IColega _colega2;

        public IColega ColegaConcreto1
        {
            get { return _colega1; }
            set { _colega1 = value; }
        }
        public IColega ColegaConcreto2
        {
            get { return _colega2; }
            set { _colega2 = value; }
        }
        public override void Enviar(string mensagem, IColega colega)
        {
            if (_colega1 == colega)
                _colega2.Notificar(mensagem);
            else
                _colega1.Notificar(mensagem);
        }
    }
}
