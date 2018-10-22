using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Program
    {

        // Create reference to our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {



         }

        [SetUp]
        public void Initialize()
        {
 
            //Navigate to Google page
            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Open URL");

        }

        [Test]
        public void ExecuteTest()
        {
            /*
            //Find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops
            element.SendKeys("executautomation");

            Console.WriteLine("Executed Test");
            */
 
            //Title
            SelemiumSetMethods.SelectDropDown(driver, "TitleId", "Mr.","Id");
            Console.WriteLine("The value from my Title is: " + SelemiumGetMethods.GetTextFromDDL(driver, "TitleId", "Id"));

            //Initial
            SelemiumSetMethods.EnterText(driver,"Initial","executautomatiom","Name");
            Console.WriteLine("The value from my Initial is: " + SelemiumGetMethods.GetText(driver, "Initial", "Name"));

            //Click
            SelemiumSetMethods.Click(driver, "Save", "Name");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("This is the second test");
        }

        [TearDown]
        public void CleanUp()
        {
            //Close browers
            driver.Close();

            Console.WriteLine("Closed Browser");

        }
    }
}
