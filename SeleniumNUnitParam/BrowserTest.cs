using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitParam
{
    class Program
    {
        //Create Global reference for our browser via WebDriver
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            //Navigate to Execute automation demo page
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&amp;Password=&amp;Login=Login");
            Console.WriteLine("Opened URL");
        }


        [Test]
        public void ExecuteTest()
        {
            //Find the Element
            IWebElement element = driver.FindElement(By.Id("q"));

            //Perform Ops
            element.SendKeys("executeautomation");

            Console.WriteLine("Executed Test");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next method");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
 }
}
