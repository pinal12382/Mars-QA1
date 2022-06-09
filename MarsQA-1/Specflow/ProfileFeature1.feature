Feature: ProfileFeature1

As a Seller
I want the feature to add my Profile Details
So that The people seeking for some skills can look into my details.
A short summary of the feature

Scenario: 01 Create new profile record with valid detail
	Given I logged in to localhost sucessfully
	When I create a New Profile Record
	Then New Profile should be created successfully

Scenario Outline: 02 Edit Profile with valid details
	Given I logged in to localhost sucessfully
	When  I update a New '<Description>','<Language>','<Languagelevel>','<Skill>','<Skilllevel>' in profile page
	Then  The Record should be upaded '<Description>','<Language>','<Languagelevel>','<Skill>','<Skilllevel>' in the profile page
	Examples:
	| Description        | Language | Languagelevel | Skill        | Skilllevel |
	| Edited Description | Hindi    | Native         | Edited Skill | Expert      |

Scenario: 03 Delete Edited profile record 
	Given I logged in to localhost sucessfully
	When I deleted Edited profile record in the profile page
	Then Edited record shold be deleted succssfully