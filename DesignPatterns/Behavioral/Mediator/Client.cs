namespace DesignPatterns.Behavioral.Mediator
{
    public class Client
    {
        public Client()
        {
            var chatRoom = new ChatRoom();

            var george = new Beatle("George");
            var paul = new Beatle("Paul");
            var ringo = new Beatle("Ringo");
            var john = new Beatle("John");

            chatRoom.Register(george);
            chatRoom.Register(paul);
            chatRoom.Register(ringo);
            chatRoom.Register(john);

            paul.Send("Ringo", "All you need is love");
            ringo.Send("George", "My sweet Lord");
            paul.Send("John", "Can't buy me love");
        }
    }
}