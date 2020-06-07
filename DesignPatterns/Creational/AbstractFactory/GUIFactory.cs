namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class GUIFactory
    {
        public abstract Button CreateButton();
        public abstract CheckBox CreateCheckBox();
    }
}