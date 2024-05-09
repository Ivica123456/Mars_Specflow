Feature: Education

Background:
	Given [ User is on the Mars Portal login page]
	When [User enters valid email and password and click on login button]

@tag1
Scenario: [1Add Education]
	When User add education including '<University>', '<Country>', '<Title>', '<Degree>','<Graduation>'
	Then User able to see added education details

	Examples: 
	| Country | University | Title | Degree   | Graduation | 
	| Croatia | SEduNet    | M.B.A | Bachalor | 2022       | 

	Scenario: [2Edit Education]
	When User edit education including '<University>', '<Country>', '<Title>', '<Degree>','<Graduation>'
	Then User able to see edited education details
	
	Examples: 
	| Country | University | Title | Degree   | Graduation |
	| Brazil  | Edunet     | B.A   | Bachalor | 2011       |

	Scenario: [3Delete Education]
	When User delete education
	Then Education should be deleted
	
	

	
