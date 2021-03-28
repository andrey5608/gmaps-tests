Feature: Find nearby restaurant
	In order to get information about some public places
	As a customer
	I want to find nearby restaurants

Background:
	Given I opened the main page

Scenario: Find nearby restaurants for your office address
	When I write to the field Query text Saarbrücker Str. 38 nearby restaurants
	Then then Results contains more than 1 result