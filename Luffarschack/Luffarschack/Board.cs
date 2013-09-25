using System;
using System.Collections.Generic;

public class Board
{
    // Properties
    public string Name { get; set; }
   
    public string MarkerX = "X"; 
    public string MarkerO = "O";

    // Constructor
    public Board()
    {
       
    }
    
    // Methods
    public void PrintBoard()
    {
        Console.WriteLine("╔═══╦═══╦═══╗");
        Console.WriteLine("║   ║   ║   ║");
        Console.WriteLine("╠═══╬═══╬═══╣");
        Console.WriteLine("║   ║   ║   ║");
        Console.WriteLine("╠═══╬═══╬═══╣");
        Console.WriteLine("║   ║   ║   ║");
        Console.WriteLine("╚═══╩═══╩═══╝");
    }
}

