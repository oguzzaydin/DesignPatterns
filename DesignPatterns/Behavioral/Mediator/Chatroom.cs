using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class ChatRoomBase
    {
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
    }

    public class ChatRoom : ChatRoomBase
    {
        private readonly Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant)) 
                _participants[participant.Name] = participant;

            participant.EnterToChatRoom(this);
        }

        public override void Send(string @from, string to, string message)
        {
            var participant = _participants[to];
            participant?.Receive(@from, message);
        }
    }

}