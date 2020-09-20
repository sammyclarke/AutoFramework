using System;
using AutoFramework.Base;
using EmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace EmployeeTest
{
    [TestClass]
    public class UnitTest1 : Base
    {
        string url = "http://localhost:64429";

        public void OpenBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browsers = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browsers = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browsers = new Browser(DriverContext.Driver);
                    break;
                default:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browsers = new Browser(DriverContext.Driver);
                    break;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            //DriverContext.Driver = new ChromeDriver();
            //DriverContext.Driver.Navigate().GoToUrl(url);

            OpenBrowser(BrowserType.Chrome);
            DriverContext.Browsers.GoToUrl(url);

            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().Login("admin", "password");
            CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();

            CurrentPage.As<EmployeePage>().ClickCreateNew();

        }

    }
}

