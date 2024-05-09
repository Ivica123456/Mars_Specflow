Feature: Manage Requests

Background:
	Given [ User is on the Mars Portal login page]
	When [User enters valid email and password and click on login button]

@tag1
Scenario: Verify that clicking on "Sent Requests" navigates to the correct page.
When the user clicks on the Manage Requests dropdown menu and selects the Sent Requests option
Then the application navigates to the /Home/SentRequest page

Scenario: Verify that clicking on "Received Request" navigates to the correct page.
When the user clicks on the Manage Requests dropdown menu and selects the ReceivedRequest option
Then the application navigates to the Home/ReceivedRequest page

