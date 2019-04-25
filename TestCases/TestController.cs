using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PageObjectModelFramework1.Global;
using PageObjectModelFramework1.CommomnFeatures;
using PageObjectModelFramework1.WebPages;
using PageObjectModelFramework1.Inputs;
using System.Threading;

namespace PageObjectModelFramework1
{
    class TestController
    {

        [SetUp]
        public void SetupMethod()
        {
            BrowserManagement.OpenBrowser();
        }
        [Test]
        public void TestCase001Login()
        {
            //BrowserManagement.OpenBrowser();
            LoginPage.Loginmethod();
            try
            {
                BrowserManagement.test = BrowserManagement.report.StartTest("Test Login");
                Assert.AreEqual("Dashboard - Dispatching System", LoginPage.localDriver.Title);
                Console.WriteLine("Login was Successful");
                BrowserManagement.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login Successful;");
            }
            catch (Exception ex)
            {
                BrowserManagement.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login Failure");
                Console.WriteLine("Unsuccessful login" + ex.InnerException);
            }

        }
        [Test]
        public void TestCase002AddingNewCustomer()
        {

            LoginPage.Loginmethod();
            CustomerPage.CustomerAction();

        }

        [Test]
        public void TestCase003AddingNewEmployee()
        {
            BrowserManagement.test = BrowserManagement.report.StartTest("Test AddEmployee");

            LoginPage.Loginmethod();
            EmployeePage.EmployeeAction();
            
            BrowserManagement.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "New Employee Entry has Successfully done");
            BrowserManagement.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Employee details already existed");

        }
        [TearDown]
        public void EndMyTest()
        {
            BrowserManagement.ClosingBrowser();

        }
    }
}
