using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {

            var assuntoConcreto = new AssuntoConcreto();
            assuntoConcreto.Anexar(new ObservadorConcreto(assuntoConcreto, "X"));
            assuntoConcreto.Anexar(new ObservadorConcreto(assuntoConcreto, "z"));
            assuntoConcreto.Anexar(new ObservadorConcreto(assuntoConcreto, "y"));

            assuntoConcreto.EstadoAssunto = "abc";
            assuntoConcreto.Notificar();

            Console.ReadLine();
        }
    }
}
