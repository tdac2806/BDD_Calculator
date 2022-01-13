Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the number is 50
	And the number is 70
    And the number is 30
	When the two numbers are added
	Then the result should be 150

Scenario: Multiply two numbers
    Given the number is 5
    And the number is 10
    And the number is 2
    When the two numbers are multiplied
    Then the result should be 100

Scenario: Divide two numbers 
    Given the number is 40
    And the number is 2
    And the number is 5
    When the two numbers are divided
    Then the result should be 4

Scenario: Divide by 0 
    Given the number is 5
    And the number is 0
    When the two numbers are divided
    Then the result should be 0

Scenario: Multiple Operation in same calcul
    Given number is 10 and the operator is *
    And number is 2 and the operator is +
    And number is 5 and the operator is -
    And the last number is 4
    When the calcul is made
    Then the result should be 21