Feature: Album
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Create an Album
	Given a user is creating an album 
	And the name is Spain
	And the genre is Landscape
	When the web request is made
	Then the album will be sucessfully created
