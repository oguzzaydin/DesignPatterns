namespace DesignPatterns.Structural.Decorator
{
    public class Client
    {
        public Client()
        {
            var textBox = new TextBox();
            textBox.Display();

            var textArea = new TextArea();
            textArea.Display();
        }
    }
}