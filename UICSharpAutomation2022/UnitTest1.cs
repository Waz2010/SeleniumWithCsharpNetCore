using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using UICSharpAutomation2022;
using UICSharpAutomation2022.Pages;

public class Tests : DriverHelper

{
    //public IWebDriver Driver;

    [SetUp]
    public void Setup()
    {
        Console.WriteLine("Set UP");
        Driver = new ChromeDriver();
    }


    [Test]
    public void LoginTest()
    {

        Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

        HomePage homePage = new HomePage();


        homePage.ClickLiginbtn();
        LoginPage loginPage = new LoginPage();
        loginPage.EnterUserNameAndPassword("admin", "password");
        loginPage.ClickLoginbtn();
        Thread.Sleep(10000);
        Assert.That(homePage.HomePageIsLogOfflinkExist(), Is.True, "Log Off link exist: Test Passed: ");
        Console.WriteLine("LoginTest Done");
    }
}

















    //[Test]
    //public void Test1()
    //{
    //    Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
    //    HomePage homePage = new HomePage();
    //    //LoginPage l = new LoginPage();
    //    homePage.ClickLiginbtn();
    //    Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
    //    Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
    //    Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
    //    IWebElement Combocontrol = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
    //    Combocontrol.Clear();
    //    Combocontrol.SendKeys("Almond");

    //    Console.WriteLine("Test 01 Pass");
    //    ///Assert.Pass();
    //}
//}