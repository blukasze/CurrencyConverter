Feature: Prepare
	In order to allow more flexible input for conversion
	As a CurrencyConverter user
	I want to be able to provide slightly incorrect input

@mytag
Scenario: Have dot instead of coma
	Given the cent value is separated by dot
	When preapare method is run
	Then dot is changed to coma

Scenario Outline: Whitespace characters removed
	Given the user inputs <Input>
	When preapare method is run
	Then the result is <Result>

	Examples: 
	| Input    | Result |
	| 1 999 21 | 199921 |
	| 1		43    | 143    |

Scenario: Combination of preparation
	Given the value has dot and whitespace
	When preapare method is run
	Then the result contain coma and no whitespace

Scenario: Number of cents is one digit
	Given the cents value is represented by one number
	When preapare method is run
	Then 0 should be added to the end