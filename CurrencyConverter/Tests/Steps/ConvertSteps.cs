using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CurrencyConverter.Tests.Steps
{
    [Binding]
    class ConvertSteps
    {
        [Given(@"I provide a valid (.*)")]
        public void GivenIProvideAValid(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the convertion method is run")]
        public void WhenTheConvertionMethodIsRun()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be minus one dollar")]
        public void ThenTheResultShouldBeMinusOneDollar()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
