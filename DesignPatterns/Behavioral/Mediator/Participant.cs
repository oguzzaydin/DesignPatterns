using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class Participant
    {
        private readonly string _name;
        private ChatRoom _chatRoom;

        protected Participant(string name)
        {
            _name = name;
        }

        public virtual string Name => _name;
        public void EnterToChatRoom(ChatRoom chatRoom) => _chatRoom = chatRoom;

        public virtual void Send(string to, string message)
        {
            _chatRoom.Send(_name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, _name, message);
        }
    }
}