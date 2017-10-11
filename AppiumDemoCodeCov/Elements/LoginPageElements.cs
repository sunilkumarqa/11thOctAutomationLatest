using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicornLibrary.Unicorn.Factory;
using UnicornLibrary.Unicorn.IServices.IElementServices.IAppiumServices;
using UnicornLibrary.Unicorn.IServices.IElementServices.ISeleniumService;
using UnicornLibrary.Unicorn.Utilities;
namespace AppiumDemoCodeCov.Elements
{
    public class LoginPageElements
    {
        public IAppiumTextBoxService usernamecov = Factory.ElementServices.GetAppiumTextboxService("xpath", "//*[@id = 'com.writer.aspiring.unittestingdemo:id/UserName']");
        public IAppiumTextBoxService passwordcov = Factory.ElementServices.GetAppiumTextboxService("xpath", "//*[@id = 'com.writer.aspiring.unittestingdemo:id/password']");
        public IAppiumButtonService loginButtoncov = Factory.ElementServices.GetAppiumButtonService("xpath", "//*[@id='com.writer.aspiring.unittestingdemo:id/text_signin']"); 
        
    }
}
