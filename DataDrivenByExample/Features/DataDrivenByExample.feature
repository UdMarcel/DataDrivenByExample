Feature: DataDrivenByExample

A short summary of the feature

@tag1
Scenario Outline: [DataDrivenByExample]
	Given I navigate to the wesbite "http://angularjs.realworld.io/#/register"
	And I Click on SignUp
	And I Enter my Username text "<Username>"
	And I Enter my email text "<Email>"
	And I Enter passowrd  text "<Password>"
	When I Click on the Sign up button 
	Then I Should be able to register succesfully

	Examples: 

	| Username    | Email                 | Password       |
	| john        | John023@yahoo.com     | PasswordSecure |
	| anthony002  | anthony002@gmail.com  | PasswordSecure |
	| benjamin003 | benjamin003@gmail.com | PasswordSecure |




	