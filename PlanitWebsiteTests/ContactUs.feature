Feature: ContactUs
	In order to contact Planit 
	As a potential client or jobseeker
	I want to be able to submit a general enquiry
	   
Scenario: Cannot submit enquiry without job title
	Given I am on the ContactUs page
		And I enter a first name of Lance
		And I enter a last name of Cordy
	When I submit my enquiry
	Then I should see an error message about missing job title
	
Scenario: Cannot submit enquiry without email address
	Given I am on the ContactUs page
		And I enter a first name of Lance
		And I enter a last name of Cordy
	When I submit my enquiry
	Then I should see an error message about missing email address

Scenario: Cannot submit enquiry without organisation
	Given I am on the ContactUs page
		And I enter a first name of Lance
		And I enter a last name of Cordy
	When I submit my enquiry
	Then I should see an error message about missing email address