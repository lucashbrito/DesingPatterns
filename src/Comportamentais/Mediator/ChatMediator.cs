namespace Mediator
{
    using System.Collections.Generic;

    public class ChatMediator : IChatMediator
    {
        private List<User> _users;

        public ChatMediator()
        {
            _users = new List<User>();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in _users)
            {
                // A mensagem não deve ser recebida pelo usuário que a enviou
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }


}
