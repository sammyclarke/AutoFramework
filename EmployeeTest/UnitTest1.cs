using System;
using EmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace EmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        string url = "http://localhost/EmployeeApp/";

        private IWebDriver Driver;



        [TestMethod]
        public void TestMethod1()
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl(url);

        }

        public void Login()
        {
            LoginPage page = new LoginPage();

            page.lnkLogin.Click();
            page.txtUserName.SendKeys("admin");
            page.txtPassword.SendKeys("password");
            page.btnLogin.Submit();
            
//            Driver.FindElement(By.LinkText("Log in")).Click();
//#
//            Driver.FindElement(By.Id("Username")).SendKeys("admin");
//            Driver.FindElement(By.Id("Password")).SendKeys("password");

//            Driver.FindElement(By.CssSelector("input.btn")).Submit();
        }

    }
}

