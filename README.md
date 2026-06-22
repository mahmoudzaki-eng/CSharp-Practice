# Employee Salary Update Using Delegates (C#)

## Project Overview

This is a simple C# console application that demonstrates the use of Delegates in Object-Oriented Programming.
The program updates employee salaries based on a custom condition (Experience level).

## Concepts Used

* Delegates
* Classes and Objects
* Arrays
* Methods
* Conditional Logic

## How It Works

* We define an Employee class with properties: Id, Name, Salary, Experience
* A delegate is used to pass a condition method to another method
* Employees who meet the condition (Experience ≥ 5) get their salary updated

## Logic

If employee Experience ≥ 5 → Salary is increased by 10%
Otherwise → No change

## Output Example

Employee: Mahmoud | New Salary: 44000
Employee: Ali | New Salary: 110000

## What I Learned

* How to use Delegates in C#
* Passing methods as parameters
* Applying conditions dynamically
* Writing flexible and reusable code

## Future Improvements

* Add file saving for employees
* Use List instead of Array
* Add user input system
