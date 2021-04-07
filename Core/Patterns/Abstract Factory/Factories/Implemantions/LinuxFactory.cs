using Patterns.Abstract_Factory.Factories.Interfaces;
using Patterns.Abstract_Factory.Implemantions;
using System;

namespace Patterns.Abstract_Factory.Factories.Implemantions
{
    class LinuxFactory : IGuiFactory
    {
        public Abstract_Factory.Interfaces.IButton createButton()
        {
            return new LinuxButton();
        }

        public Abstract_Factory.Interfaces.ICheckbox createCheckbox()
        {
            return new LinuxCheckbox();
        }

        public Abstract_Factory.Interfaces.ITextEdit createTextEdit()
        {
            return new LinuxTextEdit();
        }
    }
}
