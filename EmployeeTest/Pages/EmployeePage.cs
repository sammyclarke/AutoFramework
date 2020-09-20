using AutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest.Pages
{
    class EmployeePage : BasePage
    {
        //initialize page
        public EmployeePage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.Name, Using = "searchTerm")]
        public IWebElement btnLogin { get; set; }

    }
}
