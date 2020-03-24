using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Beatle : Participant
    {
        public Beatle(string name) : base(name)
        {
        }

        public override void Receive(string @from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(@from, message);
        }
    }
}