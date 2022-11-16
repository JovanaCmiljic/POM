
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver = POMSeleniumTestI.Driver.WebDriver;

namespace POMSeleniumTestI.Page
{
    public class LoginPage
    {




        private IWebDriver driver = WebDriver.Instance;



        IWebElement UserName = driver.FindElement(By.Id("UserName"));

        IWebElement Password = driver.FindElement(By.Id("Password"));

        IWebElement LoginButton = driver.FindElement(By.Id("login-button"));

        public void LoginOnPage(string name, string password)
        {
            UserName.SendKeys(name);
            Password.SendKeys(password);
            LoginButton.Click();
        }

    }
}
