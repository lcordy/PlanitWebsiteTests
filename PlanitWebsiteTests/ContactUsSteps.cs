using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;


namespace PlanitWebsiteTests
{
    [Binding]
    public class ContactUsSteps
    {
        private IWebDriver _driver;
        
        [Given(@"I am on the ContactUs page")]
        public void GivenIAmOnTheContactUsPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.planittesting.com/nz/Contact");            
        }

        [Given(@"I enter a first name of (.*)")]
        public void GivenIEnterAFirstNameOf(string firstName)
        {
            IWebElement firstNameInput = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_FirstName_txtText"));
            firstNameInput.SendKeys(firstName);            
        }

        [Given(@"I enter a last name of (.*)")]
        public void GivenIEnterALastNameOf(string lastName)
        {
            IWebElement lastNameInput = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_LastName_txtText"));
            lastNameInput.SendKeys(lastName);            
        }

        [When(@"I submit my enquiry")]
        public void WhenISubmitMyEnquiry()
        {
            IWebElement submit = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_btnOK"));
            submit.Click();            
        }

        [Then(@"I should see an error message about missing job title")]
        public void ThenIShouldSeeAnErrorMessageAboutMissingJobTitle()
        {
            Assert.IsTrue(_driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_JobTitle_lbe")).Displayed);            
        }

        [Then(@"I should see an error message about missing email address")]
        public void ThenIShouldSeeAnErrorMessageAboutMissingEmailAddress()
        {
            Assert.IsTrue(_driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_Email_lbe")).Displayed);           
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            _driver.Dispose();
        }
    }
}
