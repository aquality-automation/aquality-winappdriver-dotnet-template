using Aquality.Selenium.Core.Configurations;

namespace Aquality.WinAppDriver.Template.Configuration
{
    public static class Configuration
    {
        public static string ProcessName => CurrentEnvironment.GetValue<string>("processName");

        public static string Version => CurrentEnvironment.GetValue<string>("version");

        private static ISettingsFile CurrentEnvironment => Environment.CurrentEnvironment;
    }
}
