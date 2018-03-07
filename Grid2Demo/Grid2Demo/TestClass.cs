using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Threading.Tasks;


namespace Grid2Demo
{
    public class TestClass
    {
        private IWebDriver driver, driver2;

        // constructor 
        public TestClass()
        {
            driver = null;
            driver2 = null;
        }

        /*
        public void TestMethod()
        {
            
            // string NodeUrl = "http://localhost:4444/wd/hub";

            // driver = new RemoteWebDriver(new Uri(NodeUrl), DesiredCapabilities.Chrome());
            // driver.Navigate().GoToUrl(urledible);

            //driver = new ChromeDriver();
            DesiredCapabilities capability = new DesiredCapabilities();
            capability = DesiredCapabilities.Chrome();
            // capability.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));  // this line is required for running script on node having Windows OS

            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capability);
            driver2 = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capability);


            driver.Navigate().GoToUrl("https://m.ediblearrangements.com/?showteststore=1");
            Task.Delay(9000).Wait();
            driver.Close();

            driver2.Navigate().GoToUrl("https://m.ediblearrangements.com/?showteststore=1");
            Task.Delay(9000).Wait();
            driver2.Close();

        }
        */


        public void TestMethod2()
        {
            driver = new ChromeDriver();
            DesiredCapabilities capability = new DesiredCapabilities();
            capability = DesiredCapabilities.Chrome();
            capability.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capability);
            driver.Navigate().GoToUrl("https://github.com/appium/appium-desktop");
        }



        static void Main(string[] args)
        {
            /*
            string NodeUrl = "http://192.168.0.77:5566/wd/hub";
            ChromeOptions options = new ChromeOptions();
            driver = new RemoteWebDriver(new Uri(NodeUrl), options);
            Task.Delay(3).Wait();
            driver.Navigate().GoToUrl("https://m.ediblearrangements.com/?showteststore=1");
            */

            TestClass testobj = new TestClass();
            // testobj.TestMethod();
            testobj.TestMethod2();
            
            
                   
        }
    }
}
