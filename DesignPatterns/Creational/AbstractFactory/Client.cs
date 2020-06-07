namespace DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        private readonly GUIFactory _guiFactory;

        public Client(GUIFactory guiFactory)
        {
            _guiFactory = guiFactory;

            _guiFactory = new AndroidUI();
            _guiFactory.CreateButton();
            _guiFactory.CreateCheckBox();

            _guiFactory = new IosUI();
            _guiFactory.CreateButton();
            _guiFactory.CreateCheckBox();

            _guiFactory = new WebUI();
            _guiFactory.CreateButton();
            _guiFactory.CreateCheckBox();
        }
    }
}