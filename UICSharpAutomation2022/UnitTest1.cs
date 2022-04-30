using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


    public class Tests
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Set UP");
            Driver = new ChromeDriver();
        }   
    

        [Test]
        public void Test1()
        {
        Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
        Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
        Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
        IWebElement Combocontrol = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
        Combocontrol.Clear();
        Combocontrol.SendKeys("Almond");

        Console.WriteLine("Test 01 Pass");
            //Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            Assert.Pass();
            Console.WriteLine("Test 02 Pass");
        }
    }