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


        // Linh: Funderade ganska länge hur vi skulle göra if-satserna
        // Testade på olika sätt med tyvärr inget resultat...
        // Men jag gjorde en loop som går igenom varje "värde" iaf.
        // Sedan blir det fundersamt hur man t.ex. sätter
        // arrayen [0,0] = "A1" till ett värde X lr O på if sats?
        // Har fastnat.
       
      
        for (int i = 0; i < myBoard.GetLength(0); i++)
        {
            for (int j = 0; j < myBoard.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Console.WriteLine("Loopar igenom rad X och kolumn 1 :");
                }
                else if (j == 1)
                {
                    Console.WriteLine("Är inne på rad X kolumn 2:");
                }
                else
                {
                    Console.WriteLine("Är inne på rad X kolumn 3");
                }            
                
                Console.WriteLine(myBoard[i, j]);


            }

        }
        

        myBoard[2, 2] = "X";
        // Martin säger: ovan sätter jag värde "X" till C3, eftersom raderna har index 0-2.
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

    // Linh: Här är de 8:a möjliga vinnarsätten.
    /* Något som kan behövas senare. 
    public void CheckWinner(string myBoard)
    {
        switch (checkWin)
        {
            case 1:
                myBoard[0, 0] = "X" || "O";
                myBoard[0, 1] = "X" || "O";
                myBoard[0, 2] = "X" || "O";
                break;

            case 2:
                myBoard[1, 0] = "X" || "O";
                myBoard[1, 1] = "X"|| "O";
                myBoard[1, 2] = "X" || "O";
                break;

            case 3:
                myBoard[2, 0] = "X" || "O";
                myBoard[2, 1] = "X" || "O";
                myBoard[2, 2] = "X"|| "O";
                break;

            case 4:
                myBoard[0, 0] = "X" || "O";
                myBoard[1, 0] = "X" || "O";
                myBoard[2, 0] = "X" || "O";
                break;

            case 5:
                myBoard[0, 1] = "X" || "O";
                myBoard[1, 1] = "X" || "O";
                myBoard[2, 2] = "X" || "O";
                break;

            case 6:
                myBoard[0, 2] = "X" || "O";
                myBoard[1, 2] = "X" || "O";
                myBoard[2, 2] = "X" || "O";
                break;

            case 7:
                myBoard[0, 0] = "X" || "O";
                myBoard[1, 1] = "X" || "O";
                myBoard[2, 2] = "X" || "O";
                break;

            case 8:
                myBoard[2, 0] = "X" || "O";
                myBoard[1, 1] = "X" || "O";
                myBoard[0, 2] = "X"|| "O";
                break;

        }
    }
    */

    
    public void PrintBoard()
    {
        Console.WriteLine("╔═══════╦═══════╦═══════╗");
        Console.WriteLine("║       ║       ║       ║");
        Console.WriteLine("║   -   ║   -   ║   -   ║");
        Console.WriteLine("║       ║       ║       ║");
        Console.WriteLine("╠═══════╬═══════╬═══════╣");
        Console.WriteLine("║       ║       ║       ║");
        Console.WriteLine("║   -   ║   -   ║   -   ║");
        Console.WriteLine("║       ║       ║       ║");
        Console.WriteLine("╠═══════╬═══════╬═══════╣");
        Console.WriteLine("║       ║       ║       ║");
        Console.WriteLine("║   -   ║   -   ║   -   ║");
        Console.WriteLine("║       ║       ║       ║");
        Console.WriteLine("╚═══════╩═══════╩═══════╝");
    }
}


/* 
    Mikael: Boardens x/y-positioner för de 9 olika platserna (för framtida användning).
    Linh: Jag ändrade designen på boarden lite mer rektangulärt så ändrade om dina positions också.
    Console.SetCursorPosition(4, 2);    <- A1
    Console.SetCursorPosition(12, 2);    <- B1
    Console.SetCursorPosition(20, 2);   <- C1
    Console.SetCursorPosition(4, 6);    <- A2
    Console.SetCursorPosition(12, 6);    <- B2
    Console.SetCursorPosition(20, 6);   <- C2
    Console.SetCursorPosition(4, 10);   <- A3
    Console.SetCursorPosition(12, 10);   <- B3
    Console.SetCursorPosition(20, 10);  <- C3
*/
