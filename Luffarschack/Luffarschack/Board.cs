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
        string[,] myBoard = { { "A1", "B1", "C1" }, //Rad 1
                              { "A2", "B2", "C2" }, //Rad 2
                              { "A3", "B3", "C3" } };  //Rad 3

        myBoard[2, 2] = "X";
        // Martin säger: ovan sätter jag värde "X" till C2, eftersom raderna har index 0-2.
        // Jag har en tanke om att spelplanen uppdateras ungefär så här: 
        /* If (player1Choice == C2)
         * {
         *      myBoard[1,2] = "X"
         * }
         * Sen är det player2, och denne sätter ett O osv.
         * Sen får vi göra en metod checkWinner() med massa if-satser för att kolla om tre rutor i rad har samma string-värde, dvs X eller 0.
         * checkWinner() får sen köras efter varje placerad X eller O.
         */
        
        
    }
    // Methods
    public void PrintBoard()
    {
        Console.WriteLine("╔═════╦═════╦═════╗");
        Console.WriteLine("║     ║     ║     ║");
        Console.WriteLine("║  -  ║  -  ║  -  ║");
        Console.WriteLine("║     ║     ║     ║");
        Console.WriteLine("╠═════╬═════╬═════╣");
        Console.WriteLine("║     ║     ║     ║");
        Console.WriteLine("║  -  ║  -  ║  -  ║");
        Console.WriteLine("║     ║     ║     ║");
        Console.WriteLine("╠═════╬═════╬═════╣");
        Console.WriteLine("║     ║     ║     ║");
        Console.WriteLine("║  -  ║  -  ║  -  ║");
        Console.WriteLine("║     ║     ║     ║");
        Console.WriteLine("╚═════╩═════╩═════╝");
    }
}


/* 
    Mikael: Boardens x/y-positioner för de 9 olika platserna (för framtida användning).
    Console.SetCursorPosition(3, 2);    <- A1
    Console.SetCursorPosition(9, 2);    <- B1
    Console.SetCursorPosition(15, 2);   <- C1
    Console.SetCursorPosition(3, 6);    <- A2
    Console.SetCursorPosition(9, 6);    <- B2
    Console.SetCursorPosition(15, 6);   <- C2
    Console.SetCursorPosition(3, 10);   <- A3
    Console.SetCursorPosition(9, 10);   <- B3
    Console.SetCursorPosition(15, 10);  <- C3
*/