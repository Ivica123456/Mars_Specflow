Feature: Certification

A short summary of the feature

@tag1
Scenario: [1Add certification]
	When User add new certification from the JSON file located at "D:\Industry Connect\AdvancedTask-Specflow\AdvancedTask_Specflow\AdvancedTask_Specflow\TestData\certification_data.json"
	Then [Certification should be added successfully]               
	
	Scenario: [2Edit certification]
	When User edit existing certification from the JSON file located at "D:\Industry Connect\AdvancedTask-Specflow\AdvancedTask_Specflow\AdvancedTask_Specflow\TestData\editCertification_data.json"
	Then [Certification should be edited successfully]
	
	Scenario: [3Delete certification]
	When [User delete existing certification]
	Then [Certification should be deleted successfully]
	