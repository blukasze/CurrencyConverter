Feature: Validate
	In order to make sure that the provided value is correct
	As a Currency converter user
	I want to be told if my input is invalid

@mytag
Scenario Outline: Invalid input
	Given the input is <Input>
	When the validation method is run
	Then the <Response> message is shown

	Examples:
		| Input         | Response                       |
		| 1 000 000 000 | The number is too big          |
		| 1,999         | The number of cents is too big |
		| NotANumber    | Not a number                   |
	