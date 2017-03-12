Feature: Google Calculator

Scenario Outline: Verify all methods from calculator
 
Given Open the google site
When Search '<number1> <operation> <number2>'
Then Verify that the calculation result is '<result>'
Examples:
| number1 | operation | number2 | result |
|4        |+          |9        |13      |
|10       |-          |3        |7       |
|4        |*          |6        |24      |
|9        |/          |2        |4.5     |

