using AppiumDemoCodeCov.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicornLibrary.Unicorn.Factory;
using UnicornLibrary.Unicorn.IServices;
using UnicornLibrary.Unicorn.IServices.IElementServices.ISeleniumService;
using UnicornLibrary.Selenium.BaseClasses;
using System.Threading;
using OpenQA.Selenium.Appium;

namespace AppiumDemoCodeCov.Services
{
    public class LoginService
    {
        LoginPageElements pageElements = new LoginPageElements();
        ITestDataService testDataService = Factory.UnicornServices.GetTestDataService();
      
             public void LoginCov(AppiumDriver<IWebElement> driver)
        {
            //string userName = testDataService.GetFieldValue("EmailValue");
            //string password = testDataService.GetFieldValue("passwordValue");
           
            Thread.Sleep(5000);
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/UserName").SendKeys("Olivia");
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/password").SendKeys("Dunham");
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/text_signin").Click();
            Thread.Sleep(5000);
        }
     }

    }
