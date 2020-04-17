namespace Aquality.WinAppDriver.Template.Configuration
{
    public static class Configuration
    {
        public static string ProcessName => Environment.CurrentEnvironment.GetValue<string>("processName");
    }
}
