﻿Feature: PasswordChange

  As a user
  I want to be able to change my password
  So that I can keep my account secure

Background:
	Given User is on Mars Portal login page
	When [User enters valid email and password and click on login button]

@tag1
Scenario: [1Incorrect Current Password Change]
	When [User enter incorrect current password]
	Then [User can't change password Verification Failed ]
	
Scenario: [2Password not Meet Requirements]
	When [User enter a password that does not meet the requirements (e.g. less than 8 characters, contains only letters) and confirm the password]
	Then [User can't change password ]

Scenario: [3User cannot change their password if the new password is the same as the current password]
	When User entered  same new password as Current Password
	Then The user should receive an error message indicating that the new password cannot be the same as the current password


Scenario: [4User change the password, verifying the change, and reverting back to the original password while ensuring that automation tests can continue to run with the original credentials]
	When [User change to new password successfully]
	Then [User should login with new password successfully]
	Then [User is logged in and landed to profile page]
	And [user revert back to the old password]
