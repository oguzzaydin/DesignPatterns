using System;
using DesignPatterns.Behavioral.ChainOfResponsibility;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var sender = new Mail()
                .SetNext(new Notification())
                .SetNext(new Sms());

            sender.SendMessage("test");
        }
    }
}