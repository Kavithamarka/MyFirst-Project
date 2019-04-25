using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace PageObjectModelFramework1.CommomnFeatures
{
    class ExtensionMethods
    {
        public static void UserInput(IWebDriver driver, string locatorType, string locatorValue, string textValue)
        {
            if (locatorType == "Id")
            {
                driver.FindElement(By.Id(locatorValue)).SendKeys(textValue);
            }

            else if (locatorType == "Xpath")
            {
                driver.FindElement(By.XPath(locatorValue)).SendKeys(textValue);
            }
        }

        public static void ButtonClick(IWebDriver driver, string locatorType, string locatorValue)
        {
            if (locatorType == "Id")
            {
                driver.FindElement(By.Id(locatorValue)).Click();
            }

            else if (locatorType == "Xpath")
            {
                driver.FindElement(By.XPath(locatorValue)).Click();
            }
        }

        internal static void ButtonClick(object localDriver, string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        internal static void UserInput(IWebDriver localDriver, string v1, string v2)
        {
            throw new NotImplementedException();
        }

        //can create for dropdown and Assertions in future.

    }
    
    
}
