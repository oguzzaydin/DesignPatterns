namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Client
    {
        public Client()
        {
            var sender = new Mail()
                .SetNext(new Notification())
                .SetNext(new Sms());

            sender.SendMessage("Your purchase was successful");
        }
    }
}