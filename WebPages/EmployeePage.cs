using OpenQA.Selenium;
using PageObjectModelFramework1.CommomnFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObjectModelFramework1.WebPages
{
    class EmployeePage
    {
        public static IWebDriver localDriver = BrowserManagement.localDriver;
        public static void EmployeeAction()
        {
            ExcelData.PopulateInCollection("C:/Users/prade/source/repos/PageObjectModelFramework1/PageObjectModelFramework1/InputExcel.xlsx", "EmployeePageInputExcel");
            localDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            localDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a")).Click();

            for(int i = 2; i<=4; i++)
            {
                Thread.Sleep(3000);
                localDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

                localDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a")).Click();

                localDriver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
                localDriver.FindElement(By.Id("Name")).SendKeys(ExcelData.ReadData(i, "Input1"));
                localDriver.FindElement(By.Id("Username")).SendKeys(ExcelData.ReadData(i, "Input2"));
                ExtensionMethods.ButtonClick(localDriver, "Id", "EditContactButton");


                localDriver.SwitchTo().Frame(0);

                localDriver.FindElement(By.Id("FirstName")).SendKeys(ExcelData.ReadData(i, "Input3"));
                localDriver.FindElement(By.Id("LastName")).SendKeys(ExcelData.ReadData(i, "Input4"));
                localDriver.FindElement(By.Id("Phone")).SendKeys(ExcelData.ReadData(i, "Input5"));

                //ExtensionMethods.ButtonClick(localDriver, "Id", "submitButton");
                localDriver.FindElement(By.Id("submitButton")).Click();
                localDriver.SwitchTo().DefaultContent();
                Thread.Sleep(3000);
                localDriver.FindElement(By.Id("Password")).SendKeys(ExcelData.ReadData(i, "Input6"));
                localDriver.FindElement(By.Id("RetypePassword")).SendKeys(ExcelData.ReadData(i, "Input7"));
                localDriver.FindElement(By.Id("SaveButton")).Click();
                localDriver.SwitchTo().DefaultContent();
            }

           
        }
    }
}
