using System;
using System.Runtime.InteropServices;

namespace Mission2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Inputs Inputs = new Inputs();
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            //Input numbers:
            Console.WriteLine("Welcome to the dice throwing simulator!");
            int totalRolls = Inputs.GetInt("How many dice rolls would you like to simulate? ");
            int[] rollTotals = new int[12];
            //Cycle Through Rolls:
            Console.WriteLine("\n\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + totalRolls + ".");
            for (int i = 0; i < totalRolls; ++i)
            {
                int roll = dice1.RollDice() + dice2.RollDice();
                rollTotals[(roll - 1)]++;
            }
            for (int i = 1; i < rollTotals.Length; i++)
            {
                string output = "";
                output += (i + 1) + ": ";
                double percent = (rollTotals[i] / (double)totalRolls) * 100;
                for (int j = 0; j < percent; j++)
                {
                    output += "*";
                }
                Console.WriteLine(output);
            }
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}