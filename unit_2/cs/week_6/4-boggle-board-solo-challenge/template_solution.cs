using System;
					
public class Program
{
	static String[][] boggle_board = new String[][]
    {
         new String[] {"b", "r", "a", "e"},
         new String[] {"i", "o", "d", "t"},
         new String[] {"e", "c", "l", "r"},
         new String[] {"t", "a", "k", "e"}
    };
	
	public static void Main()
	{
		/* Example of the CreateWord function being used */
		int[][] coords = new int [][] { new int []{2,1}, new int []{1,1}, new int[]{1,2}, new int[]{0,3} };
		Console.WriteLine ( CreateWord(coords) ); // Prints “code”
		
		
		/* Once you implement the GetRow and GetColumn functions, you can un-comment the following lines */
		
		// GetRow(1);
		// GetColumn(2);
		
	}
	
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
	
}