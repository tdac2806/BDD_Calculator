using FluentAssertions;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator _calculator = new Calculator();
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.Numbers.Add(number);
        }

        [Given("number is (.*) and the operator is (.*)")]
        public void GivenTheCalculIs(int number, string Operator)
        {
            _calculator.Operations.Add(Tuple.Create(number, Operator));
        }

        [Given("the last number is (.*)")]
        public void FinishCalus(int number)
        {
            _calculator.Operations.Add(Tuple.Create(number, ""));
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("the calcul is made")]
        public void WhenTheCalculIsMade()
        {
            _result = _calculator.Calcul();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiply();
        }

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = _calculator.Divide();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}