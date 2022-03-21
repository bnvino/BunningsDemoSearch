Feature: Bunnings Search Feature
	Demo Bunnings search feature

Background: Pre-Condition
	#before running scenrio, url is given in the feature file for testing purpose can be given in the app config file
	Given user navigates to the url "https://www.bunnings.com.au/"
	Then the company title should be visible
	
	
	#search item without entering a value
	@seachNOItem
	Scenario: Search without typing any item
	When the user search for "" item
	And verify the "Popular searches" message is displayed in the search
	And verify the "Popular right now" message is displayed in the search

	#search invalid items
	@seachInValidItem
	Scenario Outline: Search an invalid Item
	When the user search for "<item>" item
	And click on search button
	And verify the invalid item message "<message>" "<item>" is displayed

	Examples:
	| item | message |
	| dfjlsdjflk490 | We found 0 results for   |
	| dfjlsd#$%^ | We found 0 results for   |

	#search  valid items
	@seachValidItem
	Scenario Outline: Search Valid Item
	When the user search for "<item>" item
	And click on search button
	And verify the valid item message "<message>" "<item>" displayed

	Examples:
	| item | message |
    | timber | We found 2004 results for   |
	| lawn mower | We found 146 results for   |

	