
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V105.Tethering;
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
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement Title => driver.FindElement(By.Id("TitleId"));
        public IWebElement Initial => driver.FindElement(By.Id("Initial"));
        public IWebElement FirstName => driver.FindElement(By.Id("FirstName"));
        public IWebElement MiddleName => driver.FindElement(By.Id("MiddleName"));
        public IWebElement Female => driver.FindElement(By.Name("Female"));
        public IWebElement Hindi => driver.FindElement(By.Name("Hindi"));
        public IWebElement SaveButton => driver.FindElement(By.Name("Save"));
        public IWebElement PopUp => driver.FindElement(By.CssSelector(".detail_box a"));
        public IWebElement Generate => driver.FindElement(By.Name("generate"));

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
        public void EnterFemale(string gender)
        {
            Female.SendKeys(gender);
        }
        public void EnterHindi(string languages)
        {
            Hindi.SendKeys(languages);
        }
        public void EnterSaveButton()
        {
            SaveButton.Submit();
        }




        //public void Title(string option)
        //{
        //    SelectElement drop = new SelectElement(driver.FindElement(By.Id("TitleId")));
        //    drop.SelectByText(option); // ovo vam sluzi da izabere iz drop downa Mr. ili Ms. potrebno je da mu u test kazete sta od ova dva zelite da izbare
        //}



        public void Alert()
        {
            Generate.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
        }



    }

}
