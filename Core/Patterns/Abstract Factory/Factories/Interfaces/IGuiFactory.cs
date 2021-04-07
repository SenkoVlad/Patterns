using Patterns.Abstract_Factory.Interfaces;

namespace Patterns.Abstract_Factory.Factories.Interfaces
{
    public interface IGuiFactory
    {
        IButton createButton();
        ICheckbox createCheckbox();
        ITextEdit createTextEdit();

    }
}
