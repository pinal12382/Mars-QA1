Feature: Feature1
As a Seller
I want the feature to add,Edit and delete my language Details
So that The people seeking for some skills can look into my details.



Scenario: [Create new language record with valid detail]
	Given I logged in to localhost  sucessfully
	When I create a New Language and languageLevel Entry
	Then New Language and LanguageLevel record should be created successfully


Scenario: [Edit new language record with valid detail]
	Given I logged in to localhost  sucessfully
	When I edit a New Language and languageLevel Entry
	Then New Language and LanguageLevel record should be edit successfully

	Scenario: [Delete new language record with valid detail]
	Given I logged in to localhost  sucessfully
	When I delete a New Language and languageLevel Entry
	Then New Language and LanguageLevel record should be deleted successfully
