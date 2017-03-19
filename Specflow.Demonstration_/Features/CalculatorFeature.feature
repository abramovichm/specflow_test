Feature: Simple operations
    As the user I want to perform operations with numbers
	#This is how i can put comments in the scenarios

Scenario: Check two numbers addition in simple scenario
    Given running application
    When user inputs number equal to 10
    And user presses ‘+’ button
    And user inputs number equal to 42
    And user presses ‘=’ button
    Then result should be equal to 52

@Tag1
@AVerySpecialScenario
@12345
Scenario Outline: Check addition and subtraction operations with Scenario Outline
    Given running application
    When user inputs number equal to 14
	And user presses ‘<button>’ button
    And user inputs number equal to 88
    And user presses ‘=’ button
    Then result should be equal to <result>

Examples:
    | button | result |
    | +      | 102    |
    | -      | -74    |
