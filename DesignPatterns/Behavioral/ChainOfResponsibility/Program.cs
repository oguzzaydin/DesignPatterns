namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Program
    {
        public Program()
        {
            var sender = new Mail()
                .SetNext(new Notification())
                .SetNext(new Sms());

            sender.SendMessage("Your purchase was successful");
        }
    }
}