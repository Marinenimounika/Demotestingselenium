using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




namespace Demotest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public static void Main()        {


            /*IWebDriver webDriverobj1 = new ChromeDriver();
            webDriverobj1.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");

            webDriverobj1.FindElement(By.XPath("//input[@type='email']")).SendKeys("marinenimounika109@gmail.com");

            webDriverobj1.FindElement(By.XPath("//span[@class='VfPpkd-vQzf8d']")).Click();
            webDriverobj1.FindElement(By.XPath("//input[@type='password']")).SendKeys("Lakshmidevi@1");
            webDriverobj1.FindElement(By.XPath("//span[@class='VfPpkd-vQzf8d']")).Click();
            webDriverobj1.Close();*/

            IWebDriver webDriverobj1 = new ChromeDriver();
            webDriverobj1.Navigate().GoToUrl("https://www.google.com/");

            webDriverobj1.FindElement(By.XPath("//input[@name='q']")).SendKeys("c# tutorial");

            webDriverobj1.FindElement(By.Name("btnK")).Click();
            webDriverobj1.Close();
            //this is for search





            /*if condition:
            webDriverobj1.FindElement(By.XPath("//div[@class='o6cuMc']"));
            webDriverobj1.FindElement(By.XPath("//span[@class='NlWrkb snByac']")).Click();
            webDriverobj1.FindElement(By.XPath("//div[@class='JPdR6b ILYVD qjTEB']")).Click();



            webDriverobj1.FindElement(By.XPath("//input[@id='firstName']"));

            webDriverobj1.FindElement(By.XPath("//input[@id='lastName']"));

            webDriverobj1.FindElement(By.XPath("//input[@id='username']"));

            webDriverobj1.FindElement(By.XPath("//input[@name='Passwd']"));

            webDriverobj1.FindElement(By.XPath("//input[@name='ConfirmPasswd']"));

            webDriverobj1.FindElement(By.XPath("//input[@class='VfPpkd-RLmnJb']")).Click();
            webDriverobj1.FindElement(By.XPath("//input[@class='VfPpkd-RLmnJb']")).Click();
            webDriverobj1.FindElement(By.XPath("//div[@class='VfPpkd-vQzf8d']")).Click();*/

























        }
    }
}
