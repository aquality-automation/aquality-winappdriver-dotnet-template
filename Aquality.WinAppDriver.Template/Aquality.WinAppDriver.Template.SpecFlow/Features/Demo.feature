Feature: Demo

@demo
Scenario: Add two numbers
	When I click '7' on the numpad
	And I click 'Add' operation
	And I click '8' on the numpad
	And I click 'Equals' operation
	Then the result should be '15'

@demo
Scenario: About the Author info is availabe
	When I click About the Author button
	Then About the Author window is opened
	When I click CLOSE About the Author window button
	Then About the Author window is closed