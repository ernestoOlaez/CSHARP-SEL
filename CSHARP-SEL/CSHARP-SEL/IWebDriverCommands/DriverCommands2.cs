using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CSHARP_SEL.IWebDriverCommands
{
    internal class DriverCommands2
    {
        /*
        1. Launch a new Firefox browser.
        2. Open http://demoqa.com/frames-and-windows/
        3. Use this statement to click on a New Window button "driver.FindElement(By.XPath(".//[@id='tabs-1']/div/p/a")).Click();"*
        4. Close the browser using Close() command
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Ernest!");
            IWebDriver driver=new ChromeDriver();   
            driver.Url= "https://demoqa.com/alertsWindows";


            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[1]/div/div/div[2]/span/div")).Click();


            //If the XPath doesnt works should try xfullpath
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[2]/div/ul/li")).Click();

            ////*[@id="item-0"]
            Console.WriteLine("Ernest!");
            //driver.Close(); 
        }
    }
}
