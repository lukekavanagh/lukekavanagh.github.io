# Cipher Challenge

## Learning Competencies
- Identify and explain what code is doing
- Write driver code that uses a class
- Observe how classes interact

## Summary
The N.S.A. just broke Kim Jong Un's cipher that he's been using to give instructions to his military commanders! We wrote the following program to decipher the messages. As the N.S.A.'s best programmer on staff, your job is to refactor the code.

You should work with a person in your accountability group to complete this challenge.

In this challenge, you'll work with a pair to refactor some existing code to make it more readable and follow best practices. Then you will compare your solution with the other pair(s) in your accountability group.

## Challenge Format

This challenge has a slightly different format from the others, we will be using Visual Studio or Xamarin for this one. Most of you should have Visual Studio installed, if you haven't simply go to the [PC setup](../../../week_4/how-to/cs-windows-instructions.md) page in week_4 and follow the intstructions there. A project for Visual Studio has been provided - for other enviroments please copy/paste the starting code from [starting_code.cs](starting_code.cs) and paste it so that the CipherChallenge class sits on the same level as the program class that contains the static void main method. Then add the two lines of code to the main method as shown.

```
class Program
    	{
    		// The static void main is the starting point of any Console App. ie we have to have one.
        	static void Main(string[] args)
        	{
        		// Here an instance of the cipher class is created (right of the =) and assigned to a variable of the same type that is called cipher.
        		CipherChallenge cipher = new CipherChallenge();

        		Console.WriteLine(cipher.MartianCipher("Secret Squirrel Secret Squirrel Secret Squirrel Secret Squirrel"));

        		// Add more driver code messages below

        	}
    	}

	public class CipherChallenge
	{
		//All that pretty code
	}
```

#Releases
Releases are less specific than the ToDo Lists of the previouse exercises. They are relying on your growing knowledge and understanding of workflow, remember to make small commits.

## Release 0: Run the code
Copy the code from within [my_solution.cs](my_solution.cs) in your choice of environment, execute it and look at the output. You should see a few different "I am comparing x and y" statements, and than a print out of the converted string.

## Release 1: Read the code
Identify what each line of code is doing.
Write comments above each line with an explanation.
Really focus on breaking each step down. You want to understand every line. This may take some time - talk about it on slack as needed.

Pro-Tip: If your not sure what something is doing Console WriteLine it with some identifying text.

```
Console.Writeline("The name variable is currently " + Name);
```
