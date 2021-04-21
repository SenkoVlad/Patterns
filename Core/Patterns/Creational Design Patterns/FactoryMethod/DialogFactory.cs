using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    public abstract class DialogFactory
    {
        public IButton init()
        {
            IButton button = createButton();
            return button;
        }
        public abstract IButton createButton();
    }
}
