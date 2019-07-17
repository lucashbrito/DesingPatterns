namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var originator = new Originator();
            originator.State = "on";

            var caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();

            originator.State = "off";

            originator.SetMemento(caretaker.Memento);
        }
    }
}
