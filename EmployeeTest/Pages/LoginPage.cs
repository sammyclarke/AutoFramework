using AutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest.Pages 
{
    class LoginPage : BasePage
    {
        //initialize page
        public LoginPage(IWebDriver driver): base(driver)
        {
            
        }

        [FindsBy(How = How.LinkText, Using = "Login")]
        public IWebElement lnkLogin { get; set; }

        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        public IWebElement btnLogin { get; set; }
    }
}
