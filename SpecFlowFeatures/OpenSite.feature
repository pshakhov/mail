Feature: Log in/out mail feature
	I want check the functionality of login/logout Google`s mailbox

@mytag
Scenario: Log in/out
	Given I open browser
	When I open "http://google.ru" url
	Then Title contains "google" text
    When I login by user credentials
    Then I logout from mail