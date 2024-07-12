namespace Mediator
{
    public class ChatClient
    {
        public void Main()
        {
            IChatMediator chatMediator = new ChatMediator();

            User alice = new ConcreteUser(chatMediator, "Alice");
            User bob = new ConcreteUser(chatMediator, "Bob");
            User charlie = new ConcreteUser(chatMediator, "Charlie");

            chatMediator.AddUser(alice);
            chatMediator.AddUser(bob);
            chatMediator.AddUser(charlie);

            alice.Send("Olá, pessoal!");
            bob.Send("Oi, Alice!");
            charlie.Send("Oi, Alice e Bob!");
        }
    }

}