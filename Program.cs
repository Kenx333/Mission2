using Mission2;
using System;

class DiceSimulator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        DiceRoller diceRoller = new DiceRoller();
        int[] results = diceRoller.SimulateRolls(numberOfRolls);

        PrintSimulationResults(results, numberOfRolls);

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

    static void PrintSimulationResults(int[] results, int totalRolls)
    {
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i - 2] * 100 / totalRolls;

            Console.Write($"{i}: {new string('*', percentage)}");
            Console.WriteLine();
        }
    }
}