using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    interface IButton
    {
        void Paint();
    }

    interface IGUIFactory
    {
        IButton CreateButton();
    }

    class WebFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WebButton();
        }
    }

    class DesktopFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new DesktopButton();
        }
    }

    class WebButton : IButton
    {
        public void Paint()
        {
            //Render a button in a Html style
        }
    }

    class DesktopButton : IButton
    {
        public void Paint()
        {
            //Render a button in desktop applications style
        }
    }




    class Program
    {
       public static void UsingWebFactory()
        {
            IGUIFactory factory = new WebFactory();
            //Instance of a webbutton is created
            var button = factory.CreateButton();
            button.Paint();
        }

        public static void UsingDesktopFactory()
        {
            IGUIFactory factory = new DesktopFactory();
            //Instance of a Desktopbutton is created
            var button = factory.CreateButton();
            button.Paint();
        }

    }
}
