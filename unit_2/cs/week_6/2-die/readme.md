[Week 5 Home](../)

# U2.W5: Die Class 2: Arbitrary Symbols


## Learning Competencies
- Break down problems into implementable pseudocode 
- Implement a basic class and identify when to use instance variables
- Use if/else statements, string methods, while/until loops, for loops
- Find and use built-in .NET methods to solve challenges

## Summary

Working off your previous `Die` class from [Die Class 1](../1-die), implement a new `Die` class which takes an List<String> as its input.  When `Die.Roll()` is called, it randomly returns one of these strings.  If your Die constructor is passed an empty array, throw an `ArgumentError`.  It should work like this:

```csharp
List<String> list = new List<String> {"A", "B", "C", "D", "E", "F" };
Die die = new Die(list);
die.Sides(); // should return 6, which is the number of sides in this case
die.Roll(); // returns one of {"A", "B", "C", "D", "E", "F" } randomly
```

Just to reiterate, in the previous exercise you passed in a number of sides, `sides`, and the labels were assumed to be the integers `1..sides`.  Now we're passing in a list of arbitrary labels.  We could use this to represent a [Dreidel](http://en.wikipedia.org/wiki/Dreidel) or [Boggle dice](http://en.wikipedia.org/wiki/Boggle), for example.

## Release 0: Open the exercise page in NET REPL
Go to the [relevant exercise](http://net-repl.enspiral.info/exercises/47) page in NET REPL. Pay attention to the explanation and requirements out-lined at the top of the file.

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
