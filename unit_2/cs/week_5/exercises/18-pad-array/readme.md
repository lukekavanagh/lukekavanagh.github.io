#Create a Method to Pad an Array

## Learning Competencies
- Use tests to guide development
- Break down problems into implementable pseudocode
- Differentiate between and produce destructive and non-destructive methods

## Summary:

Implement the method `Pad`.  Each method accepts a minimum size (non-negative integer) and an optional pad value as arguments.

If the array's length is less than the minimum size, `Pad` should return a new `ArrayList` padded with the pad value up to the minimum size.

For example,
```csharp
numbers = new ArrayList {1,2,3};
PadNew(numbers, 5);
```

should return

```csharp
{1,2,3,null,null}
```
And

```csharp
numbers = new ArrayList{1,2,3};
PadNew(numbers, 5, 'apple');
```

should return

```csharp
{1,2,3,'apple','apple'}
```

If the minimum size is less than or equal to the length of the ArrayList, it should just return the ArrayList.

That is, `PadOriginal(new int[] {1,2,3}, 3)` should return `{1,2,3}`.

`PadNew(myArray, 0)` should always return an ArrayList equal to `myArray`.  `PadNew` should always return a new object and the original should be intact.

If there is no padding element specified, it should pad the ArrayList with 0.

ToDo:
1. Open the exercise and carefully read the instructions![relevant exercise](http://net-repl.enspiral.info/exercises/29).
2. [Pseudocode](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/pseudocode.md).
3. Add and commit your changes.
4. Write your best Initial Solution (Remember this is off of memory).
5. Refactor the initial solution to pass the tests in NetRepl.
6. Peek at the solution and if you dont understand something put a post on slack and start a discussion.
7. Add, commit and push your code up to GitHub.

Pro-Tip: When you come across a something you don't know give yourself a set amount of time to research it, do 3-5 minutes of googling and start with "msdn + Thing in question"