Feature: DeveloperProfile
	Profile a Developer to help determine the salary to pay
	him

@mytag
Scenario: A Young Axon Developer is Paid small
	Given The age is 28
	And Gender is male
	And Marital status is single
	And Years of experience is 4
	And Has no children
	Then The pay should be 1575 dollars


@mytag
Scenario: An old Axon Developer is Paid very well
	Given The age is 37
	And Gender is male
	And Marital status is married
	And Years of experience is 9
	And Has 1 child
	When We calculate pay
	Then The pay should be 1755 dollars