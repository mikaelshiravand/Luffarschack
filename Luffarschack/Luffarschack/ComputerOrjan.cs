using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ComputerOrjan
{
    // Properties
    public static string SquareOfChoice = "";

    // Constructor
    public ComputerOrjan()
    {

    }

    // Methods
    public static void InputSquareChoice()
    {
        Random rand = new Random();

        // Slumpa ett tal mellan 1 och 9 och lagra i ComputerOrjans SquareOfChoice
        SquareOfChoice = Convert.ToString(rand.Next(1, 10));
    }

}

