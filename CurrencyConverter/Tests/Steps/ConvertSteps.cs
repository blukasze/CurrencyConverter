using CurrencyConverter.Converter;
using FluentAssertions;
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
        string inputField = "";
        string result = "";

        [Given(@"I provide a valid (.*)")]
        public void GivenIProvideAValid(string input)
        {
            inputField = input;
        }

        [When(@"the convertion method is run")]
        public void WhenTheConvertionMethodIsRun()
        {
            var preparator = new Preparator();
            var validator = new ValidatorEngine();
            var converter = new DollarConverterEngine()
            {
                Preparator = preparator,
                Validator = validator
            };

            result = converter.ConvertToWordFormat(inputField);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeMinusOneDollar(string expectedResult)
        {
            result.Should().Be(expectedResult);
        }

    }
}
