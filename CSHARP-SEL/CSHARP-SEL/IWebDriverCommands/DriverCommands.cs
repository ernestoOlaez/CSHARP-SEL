using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace CSHARP_SEL.IWebDriverCommands
{
    internal class DriverCommands
    {
     /*
     1.Launch a new Firefox browser.
     2. Open Store.DemoQA.com
     3. Get Page Title name and Title length
     3. Print Page Title and Title length on the Console.
     4. Get Page URL and Page Url Length
     5.Print Page URL and Page Url Length on the Console.
     6. Get Page Source (HTML Source code) and Page Source length
     7.Print Page Length on Console.
     8.Close the Browser.*/
        static void Main(string[] args)
        {
            
            //Launch the WebBrowser and Maximize the Window.
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";
            driver.Manage().Window.Maximize();

            //Storing Title name String variable
            String Title = driver.Title;

            //Storing Title length in Int variable.
            int TitleLengh = driver.Title.Length;

            //Printing the Title name on Console.
            Console.WriteLine("The Title is: " + Title);

            //Printing the Title length on Console.
            Console.WriteLine("The lenght of the Title is= "+TitleLengh);

            //Storing a URL in a string variable
            String PageURL=driver.Url;

            //Soring URL Lenght in Int variable
            int URLLenght = PageURL.Length;

            Console.WriteLine("UTL of the page is = " +PageURL);

            //Printing the lenght on console
            Console.WriteLine("Lenght of URL is ="+ URLLenght);

            Console.WriteLine("Ernest...");


        }
    }
}
