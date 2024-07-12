using System;

namespace Observer
{
    public class ObservadorConcreto : Observador
    {
        public string Nome { get; set; }
        public string EstadoObservador { get; set; }
        public AssuntoConcreto AssuntoConcreto { get; set; }

        public ObservadorConcreto(AssuntoConcreto assuntoConcreto, string nome)
        {
            Nome = nome;
            AssuntoConcreto = assuntoConcreto;
        }

        public override void Update()
        {
            EstadoObservador = AssuntoConcreto.EstadoAssunto;
            Console.WriteLine($"Observador: {Nome} seu novo estado e: {EstadoObservador}");

        }

        
    }
}
