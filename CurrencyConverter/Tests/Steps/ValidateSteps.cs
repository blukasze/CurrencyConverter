using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CurrencyConverter.Tests.Steps
{
    [Binding]
    class ValidateSteps
    {
        [Given(@"the input is dsadsad")]
        public void GivenTheInputIsDsadsad()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the validation method is run")]
        public void WhenTheValidationMethodIsRun()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the Not a number message is shown")]
        public void ThenTheNotANumberMessageIsShown()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
