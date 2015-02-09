[Week 5 Home](../)

# U2.W5: Implement a Reverse Polish Notation calculator


## Learning Competencies
- Decompose a problem into smaller, easier to solve components
- Manipulate and access data within data structures
- Find and use built-in .NET methods to solve challenges

## Summary
Create an `RPNCalculator` class which can evaluate expressions written in [Reverse Polish notation](http://en.wikipedia.org/wiki/Reverse_Polish_notation).

It should have an `Evaluate` instance method which takes as its input a valid RPN expression and returns its evaluation.  Your calculator only needs to handle addition, multiplication, and subtraction (not division).

Operators and numbers should be separated by a single space.

For example,

```csharp
RPNCalculator calc = new RPNCalculator();

calc.Evaluate("1 2 +");   // => 3
calc.Evaluate("2 5 *");   // => 10
calc.Evaluate("50 20 -"); // => 30

// The general rule is that 'A B op' is the same as 'A op B'
// i.e., 5 4 - is 5 - 4.
calc.Evaluate("70 10 4 + 5 * -"); // => 0
```

## Release 0: Open the exercise page in NET REPL
Go to the [relevant exercise](http://net-repl.enspiral.info/exercises/31) page in NET REPL. Pay attention to the explanation and requirements out-lined at the top of the file.

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