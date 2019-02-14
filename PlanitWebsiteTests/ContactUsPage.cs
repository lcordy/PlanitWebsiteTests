//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PlanitWebsiteTests
//{
//    public class ContactUsPage
//    {
//        private readonly IWebDriver _driver;
//        private const string PageUri = @"https://www.planittesting.com/nz/Contact";

//        public ContactUsPage(IWebDriver driver)
//        {
//            _driver = driver;
//        }
//        public static ContactUsPage NavigateTo(IWebDriver driver)
//        {
//            driver.Navigate().GoToUrl(PageUri);

//            return new ContactUsPage(driver);
//        }

//        public string FirstName
//        {
//            set
//            {
//                _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_FirstName_txtText")).SendKeys(value);
//            }
//        }

//        public string LastName
//        {
//            set
//            {
//                _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_LastName_txtText")).SendKeys(value);
//            }
//        }

//        public bool missingJobTitleErrorMessageIsDisplayed => _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_JobTitle_lbe")).Displayed;  
//        public bool missingEmailErrorMessageIsDisplayed => _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_Email_lbe")).Displayed;

//        public void SubmitEnquiry()
//        {
//            _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_btnOK")).Click();
//        }
//    }
//}
