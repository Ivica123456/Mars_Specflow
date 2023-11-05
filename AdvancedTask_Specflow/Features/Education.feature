Feature: Education

A short summary of the feature

@tag1
Scenario: [1Add Education]
	Given [User can successfully login to Mars Portal with valid credentials]
	When [[User enters valid '<email>' and '<password>' and click on login button]
	And User add education including '<University>', '<Country>', '<Title>', '<Degree>','<Graduation>'
	Then User able to see added education details

	Examples: 
	| Country | University | Title | Degree   | Graduation | email | password |
	| Croatia | SEduNet    | M.B.A | Bachalor | 2022       | ivica.cuncic@gmail.com | mars123  |

	Scenario: [2Edit Education]
	Given [User can successfully login to Mars Portal with valid credentials]
	When [[User enters valid '<email>' and '<password>' and click on login button]
	When User edit education including '<University>', '<Country>', '<Title>', '<Degree>','<Graduation>'
	Then User able to see edited education details
	
	Examples: 
	| email                  | password | Country | University | Title | Degree   | Graduation |
	| ivica.cuncic@gmail.com | mars123  | Brazil | Edunet     | B.A   | Bachalor | 2011       |

	Scenario: [3Delete Education]
	Given [User can successfully login to Mars Portal with valid credentials]
	When [[User enters valid '<email>' and '<password>' and click on login button]
	When User delete education
	Then Education should be deleted
	Examples: 
	| email                  | password |
	| ivica.cuncic@gmail.com | mars123  |

	
