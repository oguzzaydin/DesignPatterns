using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Mail : Message
    {
        protected override void Send(string message)
        {
            Console.WriteLine("Send message with mail" + message);
        }
    }
}