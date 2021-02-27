using CurrencyConverter.Validator;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CurrencyConverter.Tests.Steps
{
    [Binding]
    class ValidateSteps
    {
        string input;
        Valid validatorResponse;

        [Given(@"User inputs (.*) string")]
        public void GivenTheInputIsDsadsad(string userInput)
        {
            input = userInput;    
        }

        [When(@"the validation method is run")]
        public void WhenTheValidationMethodIsRun()
        {
            validatorResponse = ValidatorEngine.Validate(input);
        }

        [Then(@"the (.*) is shown")]
        public void ThenTheNotANumberMessageIsShown(string expectedMessage)
        {
            validatorResponse.isValid.Should().BeFalse();
            validatorResponse.Message.Should().Be(expectedMessage);
        }

    }
}
