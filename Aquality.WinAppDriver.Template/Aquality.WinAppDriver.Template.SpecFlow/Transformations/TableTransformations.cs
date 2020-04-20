using Aquality.WinAppDriver.Template.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Aquality.WinAppDriver.Template.SpecFlow.Transformations
{
    public class TableTransformations
    {
        [StepArgumentTransformation]
        public DemoModel TransformDemoModel(Table inputTable) => inputTable.CreateInstance<DemoModel>();
    }
}
