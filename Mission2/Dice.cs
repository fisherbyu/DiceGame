using System;
namespace Mission2
{
	public class Dice
	{

		public Dice()
		{
			
		}
        public int RollDice()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }
    }
}

