using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectModelFramework1.CommomnFeatures;
using PageObjectModelFramework1.Inputs;
using PageObjectModelFramework1.Global;
using System.Threading;

namespace PageObjectModelFramework1.WebPages
{
    class LoginPage
    {
        public static IWebDriver localDriver = BrowserManagement.localDriver;

        public static void Loginmethod()
        {

            //ExcelData.PopulateInCollection("C:/Users/prade/source/repos/PageObjectModelFramework1/PageObjectModelFramework1/InputExcel.xlsx", "LoginInputExcel");
            localDriver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/account/Login?ReturnUrl=%2f");

            ExtensionMethods.UserInput(localDriver, "Id", "UserName", Inputs.LoginPageResource.UserName);
            ExtensionMethods.UserInput(localDriver, "Id", "Password", Inputs.LoginPageResource.PassWord);
            ExtensionMethods.ButtonClick(localDriver, "Xpath", "//*[@id='loginForm']/form/div[3]/input[1]");
           
            localDriver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
    }
}
