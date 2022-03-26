using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace CSHARP_SEL.IWebDriverCommands
{
    internal class FirstTestCase
    {
        static void Main(string[] args)
        {

            //Launch the WebBrowser and Maximize the Window.
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";
            driver.Manage().Window.Maximize();

            //Storing the Title length in a String variable
            String Title = driver.Title;
            Console.WriteLine("The Title of the Web Site is:" +Title);
            Console.WriteLine("Sucess");
            Console.ReadLine();





        }
    }
}
