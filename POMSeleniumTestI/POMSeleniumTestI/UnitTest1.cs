using POMSeleniumTestI.Driver;
using POMSeleniumTestI.Page;

namespace POMSeleniumTestI
{
    public class TestClass
    {
        private LoginPage _loginPage;
        private HomePage _homePage;

        [SetUp]

        public void BeforeScenario()
        {
            WebDriver.Initialize();
            _loginPage = new LoginPage();
            _homePage = new HomePage();

        }

        [TearDown]
        public void AfterScenario()
        {
            WebDriver.CleanUp();
        }


        [Test]

        public void TC01_FillInputWithValidData_ShouldAllDataDisplayedInInput()
        {

            Login("execute", "automation");

            _homePage.EnterTitle("Ms.");
            _homePage.EnterInitial("JC");
            _homePage.EnterFirstName("Petar");
            _homePage.EnterMiddleName("Tamara");
            _homePage.EnterGender("female");
            _homePage.EnterLanguages("english");
            _homePage.EnterButton();
        }

        [Test]
        public void TC02_OpenPopUp_ShouldDisplayed()
        {
            Login("execute", "automation");
            _homePage.PopUp.Click();


        }


        [Test]
        public void TC03_OpenAlert_ShouldDisplayed()
        {
            Login("execute", "automation");


        }


        public void Login(string name, string pass)
        {
            _loginPage.LoginOnPage(name, pass);
        }
    }

}