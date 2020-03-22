using System.Net.Mail;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Sender
    {
        public Sender()
        {
            var sender = new Mail()
                .SetNext(new Notification())
                .SetNext(new Sms());

            sender.SendMessage("Your purchase was successful");
        }
    }
}