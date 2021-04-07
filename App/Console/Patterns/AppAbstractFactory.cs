using Patterns.Abstract_Factory;

namespace Patterns.App.Console.Patterns
{
    public class AppAbstractFactory
    {
        public Application application;
        public AppAbstractFactory(string osName)
        {
            application = (new ApplicationBuilder()).createAppContext(osName);
        }
    }
}
