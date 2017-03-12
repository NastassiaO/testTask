Feature: AmazonSteps
	Verify that I can find product by name and add it to the basket

Scenario: Verify Amazon basket
	Given Open the amazon site
	Then Search for Cucumber
	When Click on 2 result
	Then Add item to the basket
	Then Verify that the chosen item is present in the basket
