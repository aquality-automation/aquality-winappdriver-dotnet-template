using Aquality.WinAppDriver.Applications;
using TechTalk.SpecFlow;

namespace Aquality.WinAppDriver.Template.SpecFlow.Hooks
{
    [Binding]
    public class ApplicationHooks
    {
        [AfterScenario(Order = 1)]
        public void CloseApplication()
        {
            if (AqualityServices.IsApplicationStarted)
            {
                AqualityServices.Application.Quit();
                AqualityServices.ProcessManager.TryToStopProcesses(Configuration.Configuration.ProcessName);
            }
            AqualityServices.TryToStopAppiumLocalService();
        }
    }
}
