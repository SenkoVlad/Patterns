using Patterns.Abstract_Factory.Factories.Interfaces;
using Patterns.Abstract_Factory.Implemantions;
using System;

namespace Patterns.Abstract_Factory.Factories.Implemantions
{
    class MacFactory : IGuiFactory
    {
        public Abstract_Factory.Interfaces.IButton createButton()
        {
            return new MacButton();
        }

        public Abstract_Factory.Interfaces.ICheckbox createCheckbox()
        {
            return new MacCheckbox();
        }

        public Abstract_Factory.Interfaces.ITextEdit createTextEdit()
        {
            return new MacTextEdit();
        }
    }
}
