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
    class PrepareSteps
    {
        string input;
        string result;

        [Given(@"the cent value is separated by dot")]
        public void GivenTheCentValueIsSeparatedByDot()
        {
            input = "0.1";
        }

        [When(@"preapare method is run")]
        public void WhenPreapareMethodIsRun()
        {
            result = Preparator.PrepareInput(input);
        }

        [Then(@"dot is changed to coma")]
        public void ThenDotIsChangedToComa()
        {
            result.Should().Be("0,1");
        }

        [Given(@"the (.*) is")]
        public void GivenTheIs(string rawInput)
        {
            input = rawInput;
        }

        [Then(@"the result is (.*)")]
        public void ThenTheResultIs(string expectedResult)
        {
            result.Should().Be(expectedResult);
        }

        [Given(@"the value has dot and whitespace")]
        public void GivenTheValueHasDotAndWhitespace()
        {
            input = " 46 213.33 ";
        }

        [Then(@"the result is with coma and without whitespace")]
        public void ThenTheResultIsWithComaAndWithoutWhitespace()
        {
            result.Should().Be("46213,33");
        }

        [Given(@"the cents value is represented by one number")]
        public void GivenTheCentsIsValueIsRepresentedByOneNumber()
        {
            input = "1.1";
        }

        [Then(@"0 should be added to the end")]
        public void ThenShouldBeAddedToTheEnd()
        {
            result.Should().Be("1,10");
        }


    }
}
