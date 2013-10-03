using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ComputerMartin
{
    // Properties
    public string Name;

    // Constructor
    public ComputerMartin(string name)
    {
        Name = name;
    }

    // Methods
    public int SquareOfChoice()
    {
        Random rand = new Random();
        int outputSquare;
            
        // Slumpa ett tal mellan 1 och 9
        outputSquare = rand.Next(1, 10);
            
        return outputSquare;
    }   

}

