using System;
namespace Mission2
{
	public class Inputs
	{
		public int GetInt(string prompt)
		{
            Console.Write(prompt);
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }
	}
}

