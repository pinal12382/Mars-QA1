﻿Feature: ProfileFeature1

As a Seller
I want the feature to add my Profile Details
So that The people seeking for some skills can look into my details.
A short summary of the feature

Scenario: Create new profile record with valid detail
	Given I logged in to localhost sucessfully
	When I create a New Profile Record
	Then New Profile should be created successfully

Scenario Outline: Edit Profile with valid details
	Given I logged in to localhost sucessfully
	When  I update a New '<Description>','<Language>','<Language-level>','<Skill>','<Skill-level>' in profile page
	Then  The Record should be upaded '<Description>','<Language>','<Language-level>','<Skill>','<Skill-level>' in the profile page
	Examples:
	| Description        | Language | Language-level | Skill        | Skill-level |
	| Edited Description | Hindi    | Native         | Edited Skill | Expert      |