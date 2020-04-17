using Aquality.WinAppDriver.Elements.Interfaces;
using Aquality.WinAppDriver.Forms;
using OpenQA.Selenium;

namespace Aquality.WinAppDriver.Template.Forms
{
    public class AboutTheAuthorWindow : Window
    {
        private readonly IButton CloseButton;

        public AboutTheAuthorWindow() : base(By.Name("About the Author"), "About the Author")
        {
            CloseButton = FindChildElement<IButton>(By.Name("CLOSE"), "Close");
        }

        public void Close()
        {
            CloseButton.Click();
        }
    }
}
