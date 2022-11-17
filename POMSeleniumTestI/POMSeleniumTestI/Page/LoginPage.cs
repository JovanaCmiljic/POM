
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver = POMSeleniumTestI.Driver.WebDriver;

namespace POMSeleniumTestI.Page
{
    public class LoginPage
    {




        private IWebDriver driver = WebDriver.Instance;



        public IWebElement UserName => driver.FindElement(By.Name("UserName"));

        public IWebElement Password => driver.FindElement(By.Name("Password"));

        public IWebElement LoginButton => driver.FindElement(By.Name("Login"));

        public void LoginOnPage(string name, string password)
        {
            UserName.SendKeys(name);
            Password.SendKeys(password);
            LoginButton.Submit();
        }

    }
}
