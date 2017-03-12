Feature: Wikipedia

@mytag
Scenario: Verify Roman Numerals
	Given Open the wikipedia site
	Then Verify that the 'On this day…' section exists
	When Select and click the 1 entry where the year does not have a ‘BC’ suffix
	Then Validate that the Roman Numerals match with expected