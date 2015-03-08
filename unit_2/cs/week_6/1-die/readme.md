[Week 5 Home](../)

# U2.W5: Die Class 1: Numeric


## Learning Competencies
- Break down problems into implementable pseudocode 
- Implement a basic class and identify when to use instance variables
- Use if/else statements, string methods, while loops, for loops
- Find and use built-in .NET methods to solve challenges
- Explain how instance variables and methods represent the characteristics and actions of an object

## Summary
Before starting this challenge, you will want to read a bit about classes and objects. Try these: [Classes on MSDN](http://msdn.microsoft.com/en-nz/library/x9afc042.aspx) and [Lesson 7 at chsarp-station](http://www.csharp-station.com/Tutorial/CSharp/lesson07). You definitely want to research this before you try it if you have doubts as to how classes work. Classes are a different thing altogether and may be difficult to understand at first. Don't worry, you'll get lots of practice this week!

Implement a basic `Die` class which can be initialized with some number of sides.  We can then roll the die, returning a random number.  It should work like this:

```csharp
Die die = new Die(6);
die.Sides(); // should return 6
die.Roll(); // returns a random number between 1 and 6
```

If we pass `new Die(-1)`, that is, with a number less than `1`, we should raise an `ArgumentException`.  This is done using the `throw` keyword.  See the [ArgumentException documentation](http://msdn.microsoft.com/en-us/library/system.argumentexception(v=vs.110).aspx) for how to do this.

Read the [this StackOverflow thread](http://stackoverflow.com/questions/2706500/how-to-generate-random-int-number-c) for information on how to return random numbers. (The MSDN documentation examples are rather complicated and no place for a beginner!)

## Release 0: Open the exercise page in NET REPL
Go to the [relevant exercise](http://net-repl.enspiral.info/exercises/46) page in NET REPL. Pay attention to the explanation and requirements out-lined at the top of the file.

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
