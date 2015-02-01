[Week 5 Home](../)

# U2.W5: Class Warfare, Validate a Credit Card Number


## Learning Competencies
- Iterate through data structures
- Manipulate data within data structures
- Decompose a problem into smaller, easier to solve components
- Find and use built-in Ruby methods to solve challenges


## Summary
Given a credit card number we should be able to validate whether it is valid based on the [Luhn algorithm](http://en.wikipedia.org/wiki/Luhn_algorithm).

While the word [algorithm](http://en.wikipedia.org/wiki/Algorithm) sounds scary you can just think of them as a series of steps you use to solve a specific problem.  An example algorithm:

>1. Heat water until boiling
>2. Add pasta
>3. If pasta cooked, strain

The above steps if followed explicitly give us cooked pasta!

Starting with the second to last digit, double every other digit until you reach the first digit

Sum all the untouched digits and the doubled digits (doubled digits need to be broken apart, 10 becomes 1 + 0)

If the total is a multiple of ten, you have received a valid credit card number!

```csharp
Example given 4563 9601 2200 1999
Origin: 4   5   6   3   9   6   0   1   2   2   0   0   1   9   9   9
Step 1: 8   5  12   3  18   6   0   1   4   2   0   0   2   9  18   9
Step 2: 8 + 5 + 1 + 2 + 3 + 1 + 8 + 6 + 0 + 1 + 4 + 2 + 0 + 0 +2+ 9 + 1 + 8 + 9
Step 3: 70 (total above) % 10 == 0
Step 4: Profit
```

Your class will need to return `true` or `false` when we call the `CheckCard`.  Your class needs to be initialized with a credit card number that is exactly 16 digits otherwise you should receive an `ArgumentException`.

## Release 0: Open the exercise page in NET REPL
Go to the [relevant exercise](http://net-repl.enspiral.info/exercises/51) page in NET REPL. Pay attention to the explanation and requirements out-lined at the top of the file.

## Release 1: [Pseudocode](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/pseudocode.md) 
*commit your changes*

## Release 2: [Initial Solution](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/initial-solution.md) 
Write your initial solution in C# and make sure it passes all the tests. Press the "Compile and Test!" button and that will run your code and test it against the specific test units. You pass all the tests when you get all green text, otherwise it will explain which test case is failing.

*commit your changes*

## Release 3: [Refactored Solution](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/refactoring.md) 
*commit your changes*

## Release 4:  [Reflect](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/reflection-guidelines.md) 
Include your reflection in the appropriate section in your `my_solution.cs` file. ***NOTE: Reflections are mandatory!*** Commit your changes!

## Release 5: Commit and Push your changes to Github
When you feel confident with your solution, push your changes through the command line to your repo on GitHub. 
If you have done this successfully, you should be able to see your new code on your repo on [github.com](https://github.com).

## Release 6: [Review](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/review.md)