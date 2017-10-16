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
using OpenQA.Selenium.Remote;
using System.Configuration;
using System.IO;

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
            Thread.Sleep(2000);
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/UserName").SendKeys("Olivia");
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/password").SendKeys("Dunhamm");
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/text_signin").Click();
            Thread.Sleep(2000);
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/UserName").SendKeys("rtttetww");
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/password").SendKeys("ewtewtewte");
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/text_signin").Click();
            Thread.Sleep(5000);
        }
             public void CapabilitiesCov(DesiredCapabilities capabilities)
             {
               
                 capabilities.SetCapability("deviceName", ConfigurationManager.AppSettings["deviceName"]);
                 capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["platformVersion"]);
                 capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["BrowserName"]);
                 capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["platformName"]);
                 capabilities.SetCapability("appPackage", ConfigurationManager.AppSettings["appPackage"]);
                 capabilities.SetCapability("appActivity", ConfigurationManager.AppSettings["appPackage"]);
                 capabilities.SetCapability("app", "E:\\apk_files\\app-debug.apk");
                 
             }
     }

    }
