using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitParam
{
    public class BrowserTest : Hooks
    {


        [Test]
        public void GoogleTest()
        {
            /*
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("btnG")).Click();
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true), "The text selenium doest exist");
            */ 
            // Declaring and initialising the HtmlUnitWebDriver
            HtmlUnitDriver unitDriver = new HtmlUnitDriver();
            
            // open google.com webpage
            unitDriver.get("http://www.google.com");

            System.out.println("Title of the page is -> " + unitDriver.getTitle());

            // find the search edit box on the google page
            WebElement searchBox = unitDriver.findElement(By.name("q"));

            // type in Selenium
            searchBox.sendKeys("Selenium");

            // find the search button
            WebElement button = unitDriver.findElement(By.name("btnG"));

            // Click the button
            button.click();
            Assert.That(unitDriver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");
            System.out.println("Title of the page is -> " + unitDriver.getTitle());

        }

        [Test]
        public void ExecuteAutomationTest()
        {
            Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Driver.FindElement(By.Name("UserName")).SendKeys("admin");
            Driver.FindElement(By.Name("Password")).SendKeys("admin");
            Driver.FindElement(By.Name("Login")).Submit();
            System.Threading.Thread.Sleep(2000);
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");

        }


    }
}
