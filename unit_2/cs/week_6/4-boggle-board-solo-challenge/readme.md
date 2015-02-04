[Week 5 Home](../)

# U2.W5: A Nested Array to Model a Boggle Board **SOLO CHALLENGE**
Please refer to the [solo challenge](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/solo-challenges.md) guidelines in the [Phase 0 Handbook](https://github.com/dev-academy-phase0/phase-0-handbook).


## Learning Competencies
- Break down problems into implementable pseudocode 
- Create, access, and traverse nested data structures
- Explain how data structures and classes can model a real-world object
- Explain how instance variables and methods represent the characteristics and actions of an object

## Important

This challenge is not part of the curriculum on NET REPL.
To write and run this code, you'll either want to use Visual Studio on your local machine, or a .NET online sandbox environment, such as [Dotnetfiddle](http://dotnetfiddle.net)

## Summary

 We've already worked with hashes and arrays as data structures. They are handy ways of collecting and organizing data, and ideal for modeling a group of objects. In this challenge, we're going to model a grid or a board that has coordinates for each of it's cells. A logical way of modeling a board is to use a nested array (or jagged array), where a row and column are its coordinates.

Let's explore a boggle board as an example.

```cs
String[][] boggle_board = new String[][]
    {
         new String[] {"b", "r", "a", "e"},
         new String[] {"i", "o", "d", "t"},
         new String[] {"e", "c", "l", "r"},
         new String[] {"t", "a", "k", "e"}
    };
```

If we wanted to access the "r" character in the first row, we'd use the syntax below because "r" is in row 0 and under column 1. (Remember that arrays start counting from 0).

```cs
Console.WriteLine( boggle_board[0][1] ); // Prints “r”
Console.WriteLine( boggle_board[2][1] ); // Prints “c”
Console.WriteLine( boggle_board[3][3] ); // Prints “e”
Console.WriteLine( boggle_board[2][3] ); // Prints “r”
```

In boggle, you can spell out words by collecting letters that are immediately next to one another. (up, down, across, or diagonally). One of the words possible in the above boggle board is "code." Below is a simple method that takes a group of coordinates and returns a string of the corresponding `boggle board` elements. 

```cs
public static String CreateWord(int[][] coords)
{        
    String returnString = "";
    for(int i = 0; i < coords.Length; i++)
    {
        int x = coords[i][0];
        int y = coords[i][1];
        returnString += boggle_board[x][y];
    }
    return returnString;
}

int[][] coords = new int [][] { new int []{2,1}, new int []{1,1}, new int[]{1,2}, new int[]{0,3} };

Console.WriteLine ( CreateWord(coords) ); // Prints “code”
int[][] coords = new int [][] { new int []{0,1}, new int []{0,2}, new int[]{1,2} };
Console.WriteLine ( CreateWord(coords) ); // Prints what slang word?
```

## Release 0

Start by copying the code provided in the `template_solution.cs` file.
You will notice there is already some code there to make your life easier, along with a working example of the `CreateWord` method and its use.

You'll not want to write two methods: `GetRow` and `GetColumn`.

`GetRow` should take a row number as an argument and return all the elements in that row.

```cs
public static String[] GetRow(int row)
{
    // your code here
}
```

Now write a method that takes a column number and returns all the elements in the column.

```cs
public static String[] GetColumn(int column)
{
    // your code here
} 
```

## Release 1: [Initial Solution](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/initial-solution.md) 
Write your initial solution in C# and make sure it's outputting to console the correct results.

*commit your changes*

## Release 2: [Refactored Solution](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/refactoring.md) 
*commit your changes*

## Release 3:  [Reflect](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/reflection-guidelines.md) 
Include your reflection in the appropriate section in your `my_solution.cs` file. ***NOTE: Reflections are mandatory!*** Commit your changes!

## Release 4: Commit and Push your changes to Github
When you feel confident with your solution, push your changes through the command line to your repo on GitHub. 
If you have done this successfully, you should be able to see your new code on your repo on [github.com](https://github.com).

## Release 5: [Review](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/review.md)

## External Resources
* [Boggle on Wikipedia](http://en.wikipedia.org/wiki/Boggle)
* [Play Boggle online](http://www.wordplays.com/boggle)
