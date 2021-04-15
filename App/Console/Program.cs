using Patterns.App.Console.Patterns;
using Patterns.FactoryMethod;
using Patterns.Prototype;
using System;
using System.Collections.Generic;

namespace Patterns.App.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AppFactoryMethod
            //AppFactoryMethod factoryMethod = new AppFactoryMethod("Web");
            //IButton button = factoryMethod.init();

            //button.render();
            //button.onClick();
            #endregion

            #region AppAbstractFactory
            //AppAbstractFactory appAbstractFactory = new AppAbstractFactory("Linux");
            //appAbstractFactory.application.createButton();
            //appAbstractFactory.application.createCheckbox();
            //appAbstractFactory.application.createTextEdit();

            //appAbstractFactory.application.paintButton();
            //appAbstractFactory.application.paintCheckbox();
            //appAbstractFactory.application.paintTextEdit();
            #endregion

            #region AppBuilder
            //AppBuilder appBuilder = new AppBuilder();
            //appBuilder.MakeSport();
            //appBuilder.Show();
            #endregion

            #region AppPrototype
            AppPrototype appPrototype = new AppPrototype();
            List<Shape> shapes = appPrototype.Business();
            #endregion
        }
    }
}
 