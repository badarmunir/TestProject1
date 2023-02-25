using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://rekrutacja.cezs.eu/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//input[@placeholder='Adres email']")).SendKeys("badarmunir021@gmail.com");
            driver.FindElement(By.XPath("//input[@placeholder='Hasło']")).SendKeys("1992Worst@"); 
            driver.FindElement(By.XPath("//button[text()='Zaloguj się']")).Click();


            ////open Form
            //driver.FindElement(By.XPath("//button[text()='Zobacz']")).Click();
            //driver.FindElement(By.XPath("//input[@placeholder='Nazwa']")).SendKeys("badarmunir021@gmail.com");
            //driver.FindElement(By.XPath("(//input[@placeholder='Nazwa'])[1]")).SendKeys("1992Worst@");

            //driver.FindElement(By.XPath("//button[text()='Mikro przedsiębiorstwo']")).Click();

            //driver.FindElement(By.XPath("//input[@placeholder='Ulica i nr budynku']")).SendKeys("badarmunir021@gmail.com");

            //driver.FindElement(By.XPath("//input[@placeholder='Kod pocztowy']")).SendKeys("badarmunir021@gmail.com");

            //driver.FindElement(By.XPath("//input[@placeholder='Miejscowość']")).SendKeys("badarmunir021@gmail.com");


            //driver.FindElement(By.XPath("//input[@placeholder='Imię i nazwisko']")).SendKeys("badarmunir021@gmail.com");
            //driver.FindElement(By.XPath("//input[@placeholder='PESEL']")).SendKeys("badarmunir021@gmail.com");
            //driver.FindElement(By.XPath("//button[text()='Dodaj']")).Click();

        }
    }
}