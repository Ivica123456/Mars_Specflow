Feature: Manage Requests

A short summary of the feature

@tag1
Scenario: Verify that clicking on "Sent Requests" navigates to the correct page.

Given the user is on the Mars Portal login page
When the user enters valid credentials from the JSON file located at "C:\Users\Ivica\Desktop\AdvancedTask-Specflow\AdvancedTask_Specflow\AdvancedTask_Specflow\TestData\loginData.json"
And the user clicks on the Manage Requests dropdown menu and selects the Sent Requests option
Then the application navigates to the /Home/SentRequest page

Scenario: Verify that clicking on "Received Request" navigates to the correct page.

Given the user is on the Mars Portal login page
When the user enters valid credentials from the JSON file located at "C:\Users\Ivica\Desktop\AdvancedTask-Specflow\AdvancedTask_Specflow\AdvancedTask_Specflow\TestData\loginData.json"
And the user clicks on the Manage Requests dropdown menu and selects the ReceivedRequest option
Then the application navigates to the Home/ReceivedRequest page

