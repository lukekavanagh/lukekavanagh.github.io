[Week 4 Home](../)

# U2.W4: Create a Method to Pad an Array


## Learning Competencies
- Use tests to guide development
- Break down problems into implementable pseudocode 
- Differentiate between and produce destructive and non-destructive methods
- Find and use built-in Ruby methods to solve challenges

## Summary:

Implement the method `Pad`.  Each method accepts a minimum size (non-negative integer) and an optional pad value as arguments.

If the array's length is less than the minimum size, `Pad` should return a new `ArrayList` padded with the pad value up to the minimum size.

For example,
```csharp
numbers = new ArrayList {1,2,3};
PadNew(numbers, 5)
```

should return

```csharp
{1,2,3,null,null}
```
And

```csharp
numbers = new ArrayList{1,2,3};
PadNew(numbers, 5, 'apple')
```

should return

```csharp
{1,2,3,'apple','apple'}
```

If the minimum size is less than or equal to the length of the ArrayList, it should just return the ArrayList.

That is, `PadOriginal(new int[] {1,2,3}, 3)` should return `{1,2,3}`.

`PadNew(myArray, 0)` should always return an ArrayList equal to `myArray`.  `PadNew` should always return a new object and the original should be intact.

If there is no padding element specified, it should pad the ArrayList with 0.

## Release 0: Open the exercise page in NET REPL
Go to the [relevant exercise](http://net-repl.enspiral.info/exercises/29) page in NET REPL. Pay attention to the explanation and requirements out-lined at the top of the file.

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