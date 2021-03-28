Feature: FindAnAddress
	In order to get main information about some place on the map
	As a customer
	I want to find an address 

Background:
	Given I opened the main page

Scenario: Find an address
	When I write to the field Query text Saarbrücker Str. 38, 10405 Berlin, Germany
	Then then the field Street is set to Saarbrücker Str. 38