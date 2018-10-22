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


        static void Main(string[] args)
        {



         }

        [SetUp]
        public void Initialize()
        {

            // Create reference to our browser
            PropertiesCollection.driver = new ChromeDriver();

            //Navigate to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
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
            SelemiumSetMethods.SelectDropDown("TitleId", "Mr.",PropertyType.Id);
            Console.WriteLine("The value from my Title is: " + SelemiumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));

            //Initial
            SelemiumSetMethods.EnterText("Initial","executautomatiom",PropertyType.Name);
            Console.WriteLine("The value from my Initial is: " + SelemiumGetMethods.GetText("Initial", PropertyType.Name));

            //Click
            SelemiumSetMethods.Click("Save", PropertyType.Name);
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
            PropertiesCollection.driver.Close();

            Console.WriteLine("Closed Browser");

        }
    }
}
