using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using PageObjectModelFramework1.Global;
using RelevantCodes.ExtentReports;

namespace PageObjectModelFramework1.CommomnFeatures
{
    class BrowserManagement
    {
        public static IWebDriver localDriver = GlobalDriver.driver;
        public static string browser = Inputs.BrowserSelection.browser;
        public static ExtentReports report;
        public static ExtentTest test;
        public static void OpenBrowser()
        {
            if (browser == "Chrome")
            {
                localDriver = new ChromeDriver();
            }

            else if (browser == "FF")
            {
                localDriver = new FirefoxDriver();
            }
           // localDriver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/account/Login?ReturnUrl=%2f");

            report = new ExtentReports("C:/Users/prade/source/repos/PageObjectModelFramework1/PageObjectModelFramework1/Reports/ReportPage.html", false, DisplayOrder.NewestFirst);
            report.LoadConfig("C:/Users/prade/source/repos/PageObjectModelFramework1/PageObjectModelFramework1/Reports/ReportConfig.xml");
        }

        public static void ClosingBrowser()
        {
            report.EndTest(test);
            report.Flush();
            localDriver.Close();
        }
    }
}
