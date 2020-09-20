using System;
using AutoFramework.Base;
using EmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace EmployeeTest
{
    [TestClass]
    public class UnitTest1 : Base
    {
        string url = "http://localhost:64429";


        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);
            LoginPage page = new LoginPage();
            page.ClickLoginLink();
            page.Login("admin", "password");
            CurrentPage  = page.ClickEmployeeList();
            ((EmployeePage)CurrentPage).ClickCreateNew();

        }

    }
}

