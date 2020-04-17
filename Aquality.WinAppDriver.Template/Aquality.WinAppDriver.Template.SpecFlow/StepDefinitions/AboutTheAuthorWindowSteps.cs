using Aquality.WinAppDriver.Template.Forms;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.WinAppDriver.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class AboutTheAuthorWindowSteps
    {
        private readonly AboutTheAuthorWindow aboutTheAuthorWindow;

        public AboutTheAuthorWindowSteps(AboutTheAuthorWindow aboutTheAuthorWindow)
        {
            this.aboutTheAuthorWindow = aboutTheAuthorWindow;
        }

        [When(@"I click CLOSE About the Author window button")]
        public void IClickCloseAboutTheAuthorWindowButton()
        {
            aboutTheAuthorWindow.Close();
        }

        [Then(@"About the Author window is opened")]
        public void AboutTheAuthorWindowIsOpened()
        {
            Assert.IsTrue(aboutTheAuthorWindow.State.IsDisplayed, "About the Author window is closed");
        }

        [Then(@"About the Author window is closed")]
        public void AboutTheAuthorWindowIsClosed()
        {
            Assert.IsFalse(aboutTheAuthorWindow.State.IsDisplayed, "About the Author window is opened");
        }
    }
}
