[Week 6 Home](../)

# U2.W6: Virus Predictor Pair Challenge


## Learning Competencies
- Identify and explain what code is doing
- Create, access, and traverse nested data structures
- Automate repetitive tasks using loops
- Define a method's responsibility
- Identify and rewrite repetitive code
- Explain `private` and discuss when it would be used

## Summary

The C.D.C. (Centers for Disease Control) is concerned about a recent form of deadly influenza. They've implemented the following program to predict the effect of the virus by state. Eventually they want to predict the spread of the virus, which is why that data is included.

The initial program is not very [D.R.Y.](https://en.wikipedia.org/wiki/Don%27t_repeat_yourself), but the program designer went on vacation and your boss needs the model to work efficiently so they can present their findings to Congress. You've been brought in to make the code more efficient and expandable for later features such as incorporating demographic data.

## Release 0: Run the code
Look at the output. Look at the input (it's at the bottom). Explain what the program is doing.

## Release 1: `State_Data Data = new State_Data();`
Write a comment explaining the State_Data instantiation - what is it doing? and why is it in the main method?

## Release 2: Analyze `State_Data`
Take a look at the `State_Data` class. What is going on with this dictionary? What does it have in it? (HINT: look at the type declarations).

## Release 3: Comment each method
Comment each method (above the method) and define its responsibility.

## Release 4: Implement a new feature!
Create a report for all 50 states, not just the 4 listed. Is there a D.R.Y. way of doing this? Does this belong in the class or outside of it? Why?

## Release 5: Discuss `VirusEffects`
ONLY look at the `VirusEffects` method and the two methods called inside it. (Do not look at `PredictedDeaths` or `SpeedOfSpread` themselves.) It's a short but deceptive method... HINT: What is the scope of instance variables.

## Release 6: Private
What is the purpose of "private"?

## Release 7: Refactor!
Refactor the private methods `PredictedDeaths` and `SpeedOfSpread`. How can you make them more D.R.Y.?

## Release 8: [Reflect](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/coding-references/reflection-guidelines.md)

