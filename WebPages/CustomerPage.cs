using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjectModelFramework1.CommomnFeatures;
using PageObjectModelFramework1.Inputs;

namespace PageObjectModelFramework1.WebPages
{
    class CustomerPage
    {
        
        public static IWebDriver localDriver = BrowserManagement.localDriver;
        public static void CustomerAction()
        {

            ExcelData.PopulateInCollection("C:/Users/prade/source/repos/PageObjectModelFramework1/PageObjectModelFramework1/InputExcel.xlsx", "CustomerPageInputExcel");

            //ExtensionMethods.ButtonClick(localDriver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a");
            //ExtensionMethods.ButtonClick(localDriver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a");
            

            //for (int i = 2; i <= 4; i++)
            //{

                //WebDriverWait wait = new WebDriverWait(localDriver, infiniteTimespan).Until(ExpectedConditions.ElementToBeClickable);
                Thread.Sleep(3000);
                ExtensionMethods.ButtonClick(localDriver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a");
                ExtensionMethods.ButtonClick(localDriver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a");
               // ExtensionMethods.ButtonClick(localDriver, "XPath", "//*[@id='container']/p/a");
               


                //ExtensionMethods.UserInput(localDriver, "Id", "Name", ExcelData.ReadData(2,"Input1"));
                

                //ExtensionMethods.ButtonClick(localDriver, "Id", "EditContactButton");

                //localDriver.SwitchTo().Frame(0);

                //ExtensionMethods.UserInput(localDriver, "Id", "FirstName", ExcelData.ReadData(2, "Input2"));
                //ExtensionMethods.UserInput(localDriver, "Id", "LastName", ExcelData.ReadData(2, "Input3"));
                //ExtensionMethods.UserInput(localDriver, "Id", "Phone", ExcelData.ReadData(2, "Input4"));
                //ExtensionMethods.ButtonClick(localDriver, "Id", "submitButton");

                
                //localDriver.SwitchTo().DefaultContent();
                Thread.Sleep(3000);
            //}


        }
        public static void CreateCustomerButton()
        {
            ExtensionMethods.ButtonClick(localDriver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a");
            ExtensionMethods.ButtonClick(localDriver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a");

        }
    }
}
