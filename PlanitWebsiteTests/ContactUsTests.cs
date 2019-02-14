using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PlanitWebsiteTests
{

    
    public class ContactUsTests
    {
        //[Test]
        public void StartApplication()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://www.planittesting.com");

                IWebElement contactUs = driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl02_PlanIt_ContactUsATag"));

                contactUs.Click();

                Assert.AreEqual("Planit - Contact Planit: The Leaders in Quality Engineering", driver.Title);

            }           
        }

        //[Test]
        public void SubmitApplication()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("https://www.planittesting.com/nz/Contact");

                IWebElement firstName = driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_FirstName_txtText"));

                firstName.SendKeys("Lance");

                IWebElement lastName = driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_LastName_txtText"));

                lastName.SendKeys("Cordy");

                IWebElement submit = driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_btnOK"));

                submit.Click();

                string noJobTitleEnterederrorMessage = driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_JobTitle_lbe")).Text;

                Assert.AreEqual("Please enter your job title", noJobTitleEnterederrorMessage);

            }
        }
    }
}
