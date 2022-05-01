using OpenQA.Selenium;

namespace UICSharpAutomation2022.Pages
{
    public class LoginPage : DriverHelper
    {
        IWebElement LogInPagetxtUserName => Driver.FindElement(By.Id("UserName"));
        IWebElement LogInPagetxtPassword => Driver.FindElement(By.Id("Password"));
        IWebElement LogInPagebtnLogin => Driver.FindElement(By.CssSelector(".btn.btn-default"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            LogInPagetxtUserName.SendKeys(userName);
            LogInPagetxtPassword.SendKeys(password);
        }

        public void ClickLoginbtn() => LogInPagebtnLogin.Click();



    }
}
