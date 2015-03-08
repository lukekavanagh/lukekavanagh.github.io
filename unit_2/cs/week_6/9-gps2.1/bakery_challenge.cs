using System;
using System.Collections;

public class Bakery
{
	public static void Main()
	{	
		// Driver test code
		Console.WriteLine(CalculateQuantities(24, "cake").Equals("You need to make 4 cake(s)."));
		Console.WriteLine(CalculateQuantities(41, "pie").Equals("You need to make 5 pie(s), 0 cake(s), and 1 cookie(s)."));
		Console.WriteLine(CalculateQuantities(24, "cookie").Equals("You need to make 24 cookie(s)."));
		Console.WriteLine(CalculateQuantities(4, "pie").Equals("You need to make 0 pie(s), 0 cake(s), and 4 cookie(s)."));
		Console.WriteLine(CalculateQuantities(130, "pie").Equals("You need to make 16 pie(s), 0 cake(s), and 2 cookie(s)."));
		//CalculateQuantities(123, "scone"); // Should correctly raise an exception when commented out
	}
	
	public static String CalculateQuantities(int numOfPeople, String favoriteFood)
	{
		Hashtable list = new Hashtable();
		list.Add("pie", 8);
		list.Add("cake", 6);
		list.Add("cookie", 1);
		
		bool hasFave = false;
		int faveFoodQuantity = 0;
		foreach(DictionaryEntry entry in list)
		{
		if ( favoriteFood.Equals(entry.Key)	)
		{
		faveFoodQuantity = (int)entry.Value;
			hasFave = true;
		}
		}
		
		if ( !hasFave) throw new Exception("You can't make that food");
		
		if ( numOfPeople % faveFoodQuantity == 0 )
		{
			int x = numOfPeople / faveFoodQuantity;
			return "You need to make " + x + " " + favoriteFood + "(s).";
		}
		else if ( numOfPeople % faveFoodQuantity != 0 )
		{
			int numPies = 0;
			int numCakes = 0;
			int numCookies = 0;
			while( numOfPeople > 0 )
			{
				if ( numOfPeople / (int)(list["pie"]) > 0 )
				{
					numPies = numOfPeople / (int)(list["pie"]); numOfPeople = numOfPeople % (int)(list["pie"]);
				}
				else if ( numOfPeople / (int)(list["cake"]) > 0 )
				{
				numCakes = numOfPeople / (int)(list["cake"]);
				numOfPeople = numOfPeople % (int)(list["cake"]);
				}
				else
				{
				numCookies = numOfPeople;
				numOfPeople = 0;
				}
			}
			return "You need to make " + numPies + " pie(s), " + numCakes + " cake(s), and " + numCookies + " cookie(s).";
		}
		return "No-op";
	}
}