using System;

namespace State
{
    public class Contexto
    {
        private State _state;

        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine($"Estato: {_state.GetType().Name}");
            }
        }

        public Contexto(State state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}