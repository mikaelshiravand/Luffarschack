using System;
using System.Collections.Generic;

public class Board
{
    // Properties
    public string Name { get; set; }
    public string Layout { get; set; }
    // Martin: jag kom på en sak, varför ska vi använda en tvådimensionell array? Funkar ju lika bra med en vanlig. Eller???
    // jag ändrade iaf
    public string[] SquareArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    //Martin:Tror inte att dessa markörer kommer att användas, eller?
    /*public string MarkerX = "X"; 
    public string MarkerO = "O"; */

    // Constructor
    public Board()
    {
        // Martin: Kanske inte bästa sättet att deklarera en array, men det verkar funka iaf.
        SquareArray = SquareArray;
        // Behöver inte sätta något värde för en spelplan eftersom vi skriver ut en statisk Layout = GetLayout();
    }


    // Methods

    public void PrintBoard()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(0, 1);
        "  ╔═══════╦═══════╦═══════╗\n".EchoWrite();
        "  ║       ║       ║       ║\n".EchoWrite();
        "  ║   1   ║   2   ║   3   ║\n".EchoWrite();
        "  ║       ║       ║       ║\n".EchoWrite();
        "  ╠═══════╬═══════╬═══════╣\n".EchoWrite();
        "  ║       ║       ║       ║\n".EchoWrite();
        "  ║   4   ║   5   ║   6   ║\n".EchoWrite();
        "  ║       ║       ║       ║\n".EchoWrite();
        "  ╠═══════╬═══════╬═══════╣\n".EchoWrite();
        "  ║       ║       ║       ║\n".EchoWrite();
        "  ║   7   ║   8   ║   9   ║\n".EchoWrite();
        "  ║       ║       ║       ║\n".EchoWrite();
        "  ╚═══════╩═══════╩═══════╝\n".EchoWrite();
    }


    public void ChangeMarkerOnBoardSquare(string square, string marker)
    {
        string localColor = "";
        if (marker == "X")
            localColor = "Green";
        else
            localColor = "Red";
        switch (square)
        {
            case "1":
                marker.CW(6, 3, localColor);
                break;
            case "2":
                marker.CW(14, 3, localColor);
                break;
            case "3":
                marker.CW(22, 3, localColor);
                break;
            case "4":
                marker.CW(6, 7, localColor);
                break;
            case "5":
                marker.CW(14, 7, localColor);
                break;
            case "6":
                marker.CW(22, 7, localColor);
                break;
            case "7":
                marker.CW(6, 11, localColor);
                break;
            case "8":
                marker.CW(14, 11, localColor);
                break;
            case "9":
                marker.CW(22, 11, localColor);
                break;
        }
    }



    //Ändrar värdet på spelplanen under spelets gång.
    public void ChangeValueOfBoardSquare(string square, string marker)
    {
        string playerMarker = marker;
        string boardsquare = square;

        switch (boardsquare)
        {
            case "1":
                SquareArray[0] = playerMarker;
                break;
            case "2":
                SquareArray[1] = playerMarker;
                break;
            case "3":
                SquareArray[2] = playerMarker;
                break;
            case "4":
                SquareArray[3] = playerMarker;
                break;
            case "5":
                SquareArray[4] = playerMarker;
                break;
            case "6":
                SquareArray[5] = playerMarker;
                break;
            case "7":
                SquareArray[6] = playerMarker;
                break;
            case "8":
                SquareArray[7] = playerMarker;
                break;
            case "9":
                SquareArray[8] = playerMarker;
                break;
        }



    }
    //switch (checkWin)
    //    {
    //        case 1:
    //            myBoard[0, 0] = "X" || "O";
    //            myBoard[0, 1] = "X" || "O";
    //            myBoard[0, 2] = "X" || "O";
    //            break;
    public void CheckWinner()
    {
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
                    myBoard[0, 2] = "X" || "O";
                    break;

            }
        }
        */
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


// Linh: Funderade ganska länge hur vi skulle göra if-satserna
// Testade på olika sätt med tyvärr inget resultat...
// Men jag gjorde en loop som går igenom varje "värde" iaf.
// Sedan blir det fundersamt hur man t.ex. sätter
// arrayen [0,0] = "A1" till ett värde X lr O på if sats?
// Har fastnat.


/*for (int i = 0; i < myBoard.GetLength(0); i++) // Martin har kommenterat ut under utveckling av programmet
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

}*/



