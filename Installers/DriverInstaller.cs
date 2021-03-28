using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace gmapsTests.Installers
{
    public class DriverInstaller
    {
        private readonly IObjectContainer container;
        private string _name;

        public DriverInstaller(IObjectContainer container)
        {
            this.container = container;
        }

        public void Prepare(string name)
        {
            var webdriver = SetupWebDriver();
            container.RegisterInstanceAs(webdriver, name: name);
            _name = name;
        }

        private static IWebDriver SetupWebDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-notifications");
            return new ChromeDriver(options);
        }

        public void Close()
        {
            var webDriver = container.Resolve<IWebDriver>(_name);

            webDriver.Close();
            webDriver.Dispose();
        }
    }
}
