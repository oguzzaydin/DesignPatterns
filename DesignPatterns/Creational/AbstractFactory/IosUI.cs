namespace DesignPatterns.Creational.AbstractFactory
{
    public class IosUI : GUIFactory
    {
        public override Button CreateButton()
        {
            return new Button();
        }

        public override CheckBox CreateCheckBox()
        {
            return new CheckBox();
        }
    }
}