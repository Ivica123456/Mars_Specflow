Feature: Certification

A short summary of the feature

@tag1
Scenario: [1Add certification]
	Given [User can successfully login to Mars Portal with valid credentials]
	When [User enters valid '<email>' and '<password>' and click on login button]
	And [User add new certification]
	Then [Certification should be added successfully]
	Examples: 
	| email                  | password |
	| ivica.cuncic@gmail.com | mars123  |
	Scenario: [2Edit certification]
	Given [User can successfully login to Mars Portal with valid credentials]
	When [User enters valid '<email>' and '<password>' and click on login button]
	And [User edit existing certification]
	Then [Certification should be edited successfully]
	Examples: 
	| email                  | password |
	| ivica.cuncic@gmail.com | mars123  |
	Scenario: [3Delete certification]
	Given [User can successfully login to Mars Portal with valid credentials]
	When [User enters valid '<email>' and '<password>' and click on login button]
	And [User delete existing certification]
	Then [Certification should be deleted successfully]
	Examples: 
	| email                  | password |
	| ivica.cuncic@gmail.com | mars123  |
	