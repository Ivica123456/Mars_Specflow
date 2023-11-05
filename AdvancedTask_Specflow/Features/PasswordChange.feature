Feature: PasswordChange

A short summary of the feature

@tag1
Scenario: [1Incorrect Current Password Change]
	Given [User can successfully login to Mars Portal with valid credentials]
	When [[User enters valid '<email>' and '<password>' and click on login button]
	When [User enter incorrect current password]
	Then [User can't change password Verification Failed ]

	Examples: 
	| email                  | password |
	| ivica.cuncic@gmail.com | mars123  |

	Scenario: [2Password not Meet Requirements]
	Given [User can successfully login to Mars Portal with valid credentials]
	When [[User enters valid email and password and click on login button]
	When [User enter a password that does not meet the requirements (e.g. less than 8 characters, contains only letters) and confirm the password]
	Then [User can't change password ]

	Scenario: [3Change to new password]
	Given [User can successfully login to Mars Portal with valid credentials]
	When [[User enters valid email and password and click on login button]
	And [User change to new password successfully]
	Then [User should login with new password successfully]
	Then [User is logged in and landed to profile page]