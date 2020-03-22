namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class Message
    {

        private Message _next;

        public Message SetNext(Message nextMessage)
        {
            var message = this;
            while (message._next != null) message = message._next;
            message._next = nextMessage;

            return this;
        }

        public void SendMessage(string message)
        {
            Send(message);
            _next?.SendMessage(message);
        }

        protected abstract void Send(string message);
    }
}