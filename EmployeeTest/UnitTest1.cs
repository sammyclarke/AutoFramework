using System;
using EmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace EmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        string url = "http://localhost:64429";

        private IWebDriver Driver;



        [TestMethod]
        public void TestMethod1()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(url);
            Login();

        }

        public void Login()
        {
            LoginPage page = new LoginPage(Driver);

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

