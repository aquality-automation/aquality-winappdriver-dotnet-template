using Aquality.WinAppDriver.Template.Forms;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.WinAppDriver.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class CalculatorWindowSteps
    {
        private readonly CalculatorForm calculatorForm;

        public CalculatorWindowSteps(CalculatorForm calculatorForm)
        {
            this.calculatorForm = calculatorForm;
        }

        [When(@"I click About the Author button")]
        public void IClickAboutTheAuthorButton()
        {
            calculatorForm.ClickAboutTheAuthorButton();
        }

        [When(@"I click '(.*)' on the numpad")]
        public void IClickNumberOnTheNumpad(int number)
        {
            calculatorForm.ClickNumberOnTheNumpad(number);
        }

        [When(@"I click '(.*)' operation")]
        public void IClickOperation(CalculatorForm.Operation operation)
        {
            calculatorForm.ClickOperation(operation);
        }

        [Then(@"the result should be '(.*)'")]
        public void TheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, calculatorForm.CalculationResult, "Calculated result is correct");
        }
    }
}
