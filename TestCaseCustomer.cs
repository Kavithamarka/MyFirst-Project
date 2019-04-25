using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using PageObjectModelFramework1.CommomnFeatures;
using PageObjectModelFramework1.Global;
using PageObjectModelFramework1.Inputs;
using PageObjectModelFramework1.WebPages;
using System.Threading;

namespace PageObjectModelFramework1
{
    [TestFixture]
    class TestCaseCustomer
    {
        public static IWebDriver localDriver = BrowserManagement.localDriver;

        [SetUp]
        public void SetupMethod()
        {
            BrowserManagement.OpenBrowser();
        }
        [Test]
        public void TestValidateCreateNewButton()
        {

            BrowserManagement.test = BrowserManagement.report.StartTest("CreateNewCustomerbuttonvalidation");
            LoginPage.Loginmethod();
            CustomerPage.CreateCustomerButton();
            try
            {
                Thread.Sleep(2000);
                //ExtensionMethods.ButtonClick(localDriver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a");
                //ExtensionMethods.ButtonClick(localDriver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a");

                Assert.AreEqual("Index - Dispatching System", localDriver.Title);
                Console.WriteLine("Customer page has been navigated");
                BrowserManagement.test.Log(RelevantCodes.ExtentReports.logstatus.Pass, "Customer page opened");
            }
            catch (Exception e)
            {
                BrowserManagement.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Customer Page has not been navigated");
                Console.WriteLine("Customer page not opened");
            }
            

        }
        [TearDown]
        public void EndMyTest()
        {
            BrowserManagement.ClosingBrowser();
        }
    }
}
