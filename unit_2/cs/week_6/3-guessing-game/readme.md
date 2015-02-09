[Week 5 Home](../)

# U2.W5: Build a Simple Guessing Game


## Learning Competencies
- Break down problems into implementable pseudocode 
- Implement a basic class and identify when to use instance variables
- Use if/else statements, string methods, while/until loops, for loops
- Explain how instance variables and methods represent the characteristics and actions of an object

## Summary

Create a `GuessingGame` class which is initialized with an integer called `answer`.

Define an instance method `Guess` which takes an integer called `guess` as its input. The method `Guess` should return the string `"high"` if `guess` is larger than the `answer`, `"correct"` if `guess` is equal to the `answer`, and `"low"` if `guess` is lower than the `answer`.

Define an instance method `IsSolved` which returns `true` if the most recent guess was correct and `false` otherwise.

For example,

````csharp
GuessingGame game = GuessingGame.new(10);

game.IsSolved;   // => false

game.Guess(5);  // => "low"
game.Guess(20); // => "high"
game.IsSolved;   // => false

game.Guess(10); // => "correct"
game.IsSolved;   // => true
````

Or

````csharp
Random random = new Random();
GuessingGame game = GuessingGame.new(random.Next(100));
int lastGuess  = null;
int lastResult = null;

while(!game.IsSolved)
{
  if(lastGuess != null)
  {
    Console.WriteLine("Oops! Your last guess" + "(" + lastGuess + ")" + " was " + lastResult + ".");
  }

  Console.WriteLine("Enter your guess: ");
  int lastGuess  = (int) Console.ReadLine();
  int lastResult = game.Guess(lastGuess);
}

Console.WriteLine(lastGuess + " was correct!");
````

## Release 0: Open the exercise page in NET REPL
Go to the [relevant exercise](http://net-repl.enspiral.info/exercises/30) page in NET REPL. Pay attention to the explanation and requirements out-lined at the top of the file.

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