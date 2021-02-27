Feature: Validate
	In order to make sure that the provided value is correct
	As a Currency converter user
	I want to be told if my input is invalid

@mytag
Scenario Outline: Invalid input
	Given User inputs <Input> string
	And the user input goes through initial preparation
	When the validation method is run
	Then the <Response> message is shown

	Examples:
		| Input         | Response                                                           |
		| 1 000 000 000 | Number is too big, please provide a number less than 1 000 000 000 |
		| 1,999         | Too many cents. Please provide a value with cents from 0 to 99     |
		| NotANumber    | Not a number, please provide a valid number                        |
		|               | Not a number, please provide a valid number                        |