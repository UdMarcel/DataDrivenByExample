using DataDrivenByExample.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenByExample.PageObject
{
    internal class Class1
    {
        IWebDriver driver;
        public Class1 () 
        {
            driver = Hooks1.driver;
        }
        IWebElement SignUp => driver.FindElement(By.XPath("//a[@class='nav-link active']"));
        IWebElement Username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));

        IWebElement Email => driver.FindElement(By.XPath("//input[@type='email']"));

        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));

        IWebElement Login => driver.FindElement(By.CssSelector("button[type='submit']"));

        IWebElement NewArticle => driver.FindElement(By.CssSelector("a[class='nav-link active']"));


        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);

        }
        public void ClickOnSignUP()
        {
            SignUp.Click();

        }

        public void EnterUsername(string username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys(username + randomInt);
        }

        public void EnterEmail(string email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys(randomInt + email);
            //+ "@gmail.com"
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }
        public void ClickOnLogin()
        {
            Login.Click();
        }
        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }

    }
}
