
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POMSeleniumTestI.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = POMSeleniumTestI.Driver.WebDriver;

namespace POMSeleniumTestI.Page
{
    public class HomePage
    {
        private IWebDriver _driver = WebDriver.Instance;

        public IWebElement Title => _driver.FindElement(By.Id("TitleId"));
        public IWebElement Initial => _driver.FindElement(By.Id("Initial"));
        public IWebElement FirstName => _driver.FindElement(By.Id("FirstName"));
        public IWebElement MiddleName => _driver.FindElement(By.Id("MiddleName"));
        public IWebElement Gender => _driver.FindElement(By.Id("Female"));
        public IWebElement Languages => _driver.FindElement(By.Id("english"));
        public IWebElement Button => _driver.FindElement(By.Id("Save"));
        public IWebElement PopUp => _driver.FindElement(By.CssSelector(".detail_box a"));

        public void EnterTitle(string option)
        {
            Title.SendKeys(option);
        }
        public void EnterInitial(string initial)
        {
            Initial.SendKeys(initial);
        }
        public void EnterFirstName(string name)
        {
            FirstName.SendKeys(name);
        }
        public void EnterMiddleName(string name)
        {
            MiddleName.SendKeys(name);
        }
        public void EnterGender(string gender)
        {
            Gender.SendKeys(gender);
        }
        public void EnterLanguages(string languages)
        {
            Languages.SendKeys(languages);
        }
        public void EnterButton()
        {
            Button.Click();
        }




        public void SelectOption(string option)
        {
            SelectElement drop = new SelectElement(_driver.FindElement(By.Id("TitleId")));
            drop.SelectByText(option); // ovo vam sluzi da izabere iz drop downa Mr. ili Ms. potrebno je da mu u test kazete sta od ova dva zelite da izbare
        }


    }
}
