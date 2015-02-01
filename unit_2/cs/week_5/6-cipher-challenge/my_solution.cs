using System;
using System.Collections.Generic;
using System.Collections;

public class CipherChallenge
{
    // RUN THE CODE BEFORE YOU MAKE ANY CHANGES.
    // What if the code doesn't even work? (It does, but you should still always run it before making changes)!
    // HINTS:
    //   If you do not understand what a line of code is doing. Go into the console and try to figure out how it works.
    //   Use Console.WriteLine statements to track what your program is doing at each step. See line 65 for an example.
    
	public static void Main()
	{
		Console.WriteLine(MartianCipher("m^aerx%e&gsoi!"));
	}
  
	public static String MartianCipher(String codedMessage)
	{
		// Check out this method in the console to see how it works! Also refer to the documentation.
     	char[] input = codedMessage.ToLower().ToCharArray();
        List<Char> decodedLetters = new List<Char>();
        
        Dictionary<Char,Char> cipher = new Dictionary<Char, Char>()
        {
            // This is technically a shift of four letters...Can you think of a way to automate this? Is a Dictionary
            // the best data structure for this problem? What are the pros and cons of Dictionaries?
            {'e', 'a'},
            {'f', 'b'},
            {'g', 'c'},
            {'h', 'd'},
            {'i', 'e'},
            {'j', 'f'},
            {'k', 'g'},
            {'l', 'h'},
            {'m', 'i'},
            {'n', 'j'},
            {'o', 'k'},
            {'p', 'l'},
            {'q', 'm'},
            {'r', 'n'},
            {'s', 'o'},
            {'t', 'p'},
            {'u', 'q'},
            {'v', 'r'},
            {'w', 's'},
            {'x', 't'},
            {'y', 'u'},
            {'z', 'v'},
            {'a', 'w'},
            {'b', 'x'},
            {'c', 'y'},
            {'d', 'z'}
        };
        
        foreach (Char x in input) // What is foreach doing here?
        {
            bool foundMatch = false;  // Why would this be assigned to false from the outset? What happens when it's true?
            foreach(KeyValuePair<Char,Char> pair in cipher)
            {
                Char y = pair.Key;
                if (x == y)  // What is this comparing? Where is it getting x? Where is it getting y? What are those variables really?
                {
                    Console.WriteLine("I am comparing x and y. X is " + x + " and Y is " + y + ".\n");
                    decodedLetters.Add(cipher[y]); // How else could cipher[y] be expressed?
                    foundMatch = true;
                    break;  // Why is it breaking here?
                }
                else if (x == '@' || x == '#' || x == '$' || x == '%'|| x == '^' || x == '&'|| x =='*') //What the heck is this doing?
                {
                    decodedLetters.Add(' ');
                    foundMatch = true;
                    break;
                }
                else if (Char.IsDigit(x)) // Try this out in IRB. What does   " (0..9).to_a "    do?
                {
                    decodedLetters.Add(x);
                    foundMatch = true;
                    break;
                }
            }
            if (!foundMatch)  // What is this looking for?
            {
                decodedLetters.Add(x);
            }
        }
        
        String decodedSentence = "";
        
        foreach (Char letter in decodedLetters)
        {
            decodedSentence = String.Concat(decodedSentence, letter);
        }
        
        return decodedSentence; // What is this returning?
    }
}
