Feature: Certification

Background:
	Given [ User is on the Mars Portal login page]
	When [User enters valid email and password and click on login button]

@tag1
Scenario: [1Add certification]
	When User add new certification from the JSON file located at "D:\Industry Connect\Mars_Specflow\AdvancedTask_Specflow\AdvancedTask_Specflow\TestData\certification_data.json"
	Then [Certification should be added successfully]               
	
	Scenario: [2Edit certification]
	When User edit existing certification from the JSON file located at "D:\Industry Connect\Mars_Specflow\AdvancedTask_Specflow\AdvancedTask_Specflow\TestData\editCertification_data.json"
	Then [Certification should be edited successfully]
	
	Scenario: [3Delete certification]
	When [User delete existing certification]
	Then [Certification should be deleted successfully]
	