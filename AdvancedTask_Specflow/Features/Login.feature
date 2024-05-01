Feature: Login

Login to Mars Portal

@tag1
Scenario: [ 1User can successfully login to Mars Portal with valid credentials]
	Given [ User is on the Mars Portal login page]
	When [User enters valid email and password and click on login button]
	Then [User is successfully logged in to Mars Portal]

	
Scenario Outline: [2User cannot successfully login to Mars Portal with invalid credentials]
	Given User is on Mars Portal login page
	When User enters invalid '<email>' and '<password>' and click on login button
	Then User should see an error message indicating that the login credentials are invalid

Examples:
	| email                  | password |
	| ivica.cuncic@gmail.com | zeki123  |
	| invalid@gmail.com      | mars123  |
		

Scenario Outline: [ 4User cannot successfully login to Mars Portal with Json data negative credentials]
	Given User is on Mars Portal login page
	When User enters Json data nagative credentials and click on login button
	Then User should see an error message indicating that the valid login credentials are required

Scenario Outline: [ 5User can successfully login to Mars Portal with valid Json data credentials]
	Given User is on Mars Portal login page
	When User enters valid Json data credentials and click on login button
	Then User should see an success message that is logged in to Mars Portal