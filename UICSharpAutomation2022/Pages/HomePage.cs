using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UICSharpAutomation2022.Pages
{
    public class HomePage : DriverHelper
    {

        public IWebElement HomePageInkLogin => Driver.FindElement(By.LinkText("Login"));
        public IWebElement HomePageInkLogOff => Driver.FindElement(By.LinkText("Log off"));


        public void ClickLiginbtn() => HomePageInkLogin.Click();
        public bool HomePageIsLogOfflinkExist() => HomePageInkLogOff.Displayed;
        
      


    }
}
