using Aquality.WinAppDriver.Elements.Interfaces;
using Aquality.WinAppDriver.Forms;
using OpenQA.Selenium;

namespace Aquality.WinAppDriver.Template.Forms
{
    public class AboutTheAuthorWindow : Window
    {
        private IButton CloseButton => FindChildElement<IButton>(By.Name("CLOSE"), "Close");

        public AboutTheAuthorWindow() : base(By.Name("About the Author"), "About the Author")
        {
        }

        public void Close()
        {
            CloseButton.Click();
        }
    }
}
