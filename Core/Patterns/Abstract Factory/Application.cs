using Patterns.Abstract_Factory.Factories.Interfaces;
using Patterns.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    public class Application
    {
        IGuiFactory factory;

        IButton button;
        ICheckbox checkbox;
        ITextEdit textEdit;

        public Application(IGuiFactory factory)
        {
            this.factory = factory;
        }

        public void createButton()
        {
            button = factory.createButton();
        }
        public void createCheckbox()
        {
            checkbox = factory.createCheckbox();
        }
        public void createTextEdit()
        {
            textEdit = factory.createTextEdit();
        }
        public void paintButton()
        {
            button.Paint();
        }
        public void paintCheckbox()
        {
            checkbox.Paint();
        }

        public void paintTextEdit()
        {
            textEdit.Paint();
        }
    }
}
