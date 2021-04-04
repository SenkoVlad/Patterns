using Patterns.FactoryMethod;
using Patterns.FactoryMethod.Factories;

namespace Patterns.App.Console
{
    class AppFactoryMethod
    {
        private DialogFactory Dialog;
        public string OS;

        public AppFactoryMethod( string oS)
        {
            OS = oS;
            if (oS == "Windows")
                Dialog = new WindowsDialog();
            else if (oS == "Web")
                Dialog = new HtmlDialog();
        }

        public IButton init()
        {
             return Dialog.init();
        }
    }
}
