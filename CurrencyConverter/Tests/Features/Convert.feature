Feature: Convert
	In order to have a word represantation of a number
	As a Currency Converter user
	I want to be convert a number into it's words represantation

@mytag
Scenario Outline: Convert valid number
	Given I provide a valid <Number>
	When the convertion method is run
	Then the result should be <Result>

	Examples:
		| Number         | Result                                                                                                                    |
		| -1             | minus one dollar                                                                                                          |
		| 0              | zero dollars                                                                                                              |
		| 0,1            | zero dollars and ten cents                                                                                                |
		| 0.01           | zero dollars and one cent                                                                                                 |
		| 1              | one dollar                                                                                                                |
		| 1.00           | one dollar                                                                                                                |
		| 2              | two dollars                                                                                                               |
		| 3              | three dollars                                                                                                             |
		| 4              | four dollars                                                                                                              |
		| 5              | five dollars                                                                                                              |
		| 6              | six dollars                                                                                                               |
		| 7              | seven dollars                                                                                                             |
		| 8              | eight dollars                                                                                                             |
		| 9              | nine dollars                                                                                                              |
		| 10             | ten dollars                                                                                                               |
		| 11             | eleven dollars                                                                                                            |
		| 12             | twelve dollars                                                                                                            |
		| 13             | thirteen dollars                                                                                                          |
		| 14             | fourteen dollars                                                                                                          |
		| 15             | fifteen dollars                                                                                                           |
		| 16             | sixteen dollars                                                                                                           |
		| 17             | seventeen dollars                                                                                                         |
		| 18             | eighteen dollars                                                                                                          |
		| 19             | nineteen dollars                                                                                                          |
		| 20             | twenty dollars                                                                                                            |
		| 25,1           | twenty-five dollars and ten cents                                                                                         |
		| 30             | thirty dollars                                                                                                            |
		| 40             | forty dollars                                                                                                             |
		| 50             | fifty dollars                                                                                                             |
		| 60             | sixty dollars                                                                                                             |
		| 70             | seventy dollars                                                                                                           |
		| 80             | eighty dollars                                                                                                            |
		| 90             | ninety dollars                                                                                                            |
		| 45 100         | forty-five thousand one hundred dollars                                                                                   |
		| 45 101         | forty-five thousand one hundred one dollar                                                                                |
		| 45 131         | forty-five thousand one hundred thirty-one dollars                                                                        |
		| 999 999 999.99 | nine hundred ninety-nine million nine hundred ninety-nine thousand nine hundred ninety-nine dollars and ninety-nine cents |