using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Sms : Message
    {
        protected override void Send(string message)
        {
            Console.WriteLine("Send message with sms" + message);
        }
    }
}