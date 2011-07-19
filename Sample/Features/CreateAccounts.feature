Feature: Create account
	In order to gain additional access to the website
	As a user
	I want to create an account for the website

Scenario: Submit a valid create account form
	Given the following accounts exist
	| FirstName | LastName | Email   |
	| Howard    | Roark    | h@r.com |
	When I submit the following Create Account form
	| Field     | Value   |
	| FirstName | John    |
	| LastName  | Galt    |
	| Email     | j@g.com |
	Then the following accounts should exist
	| FirstName | LastName | Email   |
	| Howard    | Roark    | h@r.com |
	| John      | Galt     | j@g.com |