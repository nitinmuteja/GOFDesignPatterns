using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AbstractFactory
{
    interface AbstractFactory
    {
        IGUIFactory GetGuiFactory();
        IDeploymentEnvironment GetDeploymentEnvironment();

    }

    public class ConcreteFactory1 : AbstractFactory
    {
        public IDeploymentEnvironment GetDeploymentEnvironment()
        {
            return new WebEnvironment();
        }

        public IGUIFactory GetGuiFactory()
        {
            return new WebFactory();
        }
    }

    public class ConcreteFactory2 : AbstractFactory
    {
        public IDeploymentEnvironment GetDeploymentEnvironment()
        {
            return new DesktopEnvironment();
        }

        public IGUIFactory GetGuiFactory()
        {
            return new DesktopFactory();
        }
    }

    public interface IDeploymentEnvironment
    {
       string GetDeploymentType();

    }

   public class WebEnvironment : IDeploymentEnvironment
    {
       public string GetDeploymentType()
        {
            return "WebServer";
        }
    }

    public class DesktopEnvironment : IDeploymentEnvironment
    {
        public string GetDeploymentType()
        {
            return "Standalone";
        }
    }

   public interface IButton
    {
        void Paint();
    }

   public interface IGUIFactory
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
            AbstractFactory factory = new ConcreteFactory1();
            //Instance of a web environment and web gui factory is created
            var deploymentEnv = factory.GetDeploymentEnvironment();
           var guiFactory= factory.GetGuiFactory();
            var button = guiFactory.CreateButton();
            button.Paint();
        }

        public static void UsingDesktopFactory()
        {
            AbstractFactory factory = new ConcreteFactory1();
            //Instance of a desktop environment and gui factory is created
            var deploymentEnv = factory.GetDeploymentEnvironment();
            var guiFactory = factory.GetGuiFactory();
            var button = guiFactory.CreateButton();
            button.Paint();
        }

    }
}
