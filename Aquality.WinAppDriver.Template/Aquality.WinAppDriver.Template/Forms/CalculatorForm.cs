﻿using Aquality.WinAppDriver.Elements.Interfaces;
using Aquality.WinAppDriver.Forms;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Aquality.WinAppDriver.Template.Forms
{
    public class CalculatorForm : Form
    {
        private static readonly IDictionary<Operation, string> OperationsLocators = new Dictionary<Operation, string>
        {
            { Operation.Add, "+" },
            { Operation.Equals, "=" }
        };

        private ILabel ResultsLabel => ElementFactory.GetLabel(By.XPath("//*[@AutomationId='48']"), "Results bar");
        
        private IButton AboutTheAuthorButton => ElementFactory.GetButton(By.XPath("//*[@AutomationId='30']"), "About the Author");

        public CalculatorForm() : base(By.Name("Day Maxi Calc  v.1.5 Freeware"), "Calculator")
        {
        }

        public int CalculationResult => int.Parse(ResultsLabel.Text);

        public void ClickAboutTheAuthorButton()
        {
            AboutTheAuthorButton.State.WaitForClickable();
            AboutTheAuthorButton.MouseActions.DoubleClick();
        }

        public void ClickOperation(Operation operation)
        {
            var button = ElementFactory.GetButton(By.Name(OperationsLocators[operation]), operation.ToString());
            button.State.WaitForClickable();
            button.Click();
        }

        public void ClickNumberOnTheNumpad(int number) => ElementFactory.GetButton(By.Name(number.ToString()), number.ToString()).Click();

        public enum Operation
        {
            Add,
            Equals
        }
    }
}
