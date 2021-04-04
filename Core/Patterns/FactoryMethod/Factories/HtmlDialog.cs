using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod.Factories
{
    public class HtmlDialog : DialogFactory
    {
        public override IButton createButton()
        {
            return new HTMLButton();
        }
    }
}
