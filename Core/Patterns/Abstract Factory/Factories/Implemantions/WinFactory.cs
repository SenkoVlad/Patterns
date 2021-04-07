using Patterns.Abstract_Factory.Factories.Interfaces;
using Patterns.Abstract_Factory.Implemantions;
using System;

namespace Patterns.Abstract_Factory.Factories.Implemantions
{
    class WinFactory : IGuiFactory
    {
        public Abstract_Factory.Interfaces.IButton createButton()
        {
            return new WinButton();
        }

        public Abstract_Factory.Interfaces.ICheckbox createCheckbox()
        {
            return new WinCheckbox();
        }
        public Abstract_Factory.Interfaces.ITextEdit createTextEdit()
        {
            return new WinTextEdit();
        }
    }
}
