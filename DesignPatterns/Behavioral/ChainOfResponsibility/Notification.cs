using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Notification : Message
    {
        protected override void Send(string message)
        {
            Console.WriteLine("Send message with push notification" + message);
        }
    }
}