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
            localColor = "Blue";

        // MIKAEL: Fixad kod som gör att man bara kan sätta värdet på en plats en gång per spel 
        // TODO: Resetta tillbaka SquareArray's values till 1-9 efter ett spel är färdigt
        // TODO: Göra så att man inte kan skriva ett nummer som redan är taget (just nu slösas ens tur om man råkar skriva ett nummer som redan använts)

        if (square == "1" && SquareArray[0] == "1")
        {
            marker.CW(6, 3, localColor);
        }
        else if (square == "2" && SquareArray[1] == "2")
        {
            marker.CW(14, 3, localColor);
        }
        else if (square == "3" && SquareArray[2] == "3")
        {
            marker.CW(22, 3, localColor);
        }
        else if (square == "4" && SquareArray[3] == "4")
        {
            marker.CW(6, 7, localColor);
        }
        else if (square == "5" && SquareArray[4] == "5")
        {
            marker.CW(14, 7, localColor);
        }
        else if (square == "6" && SquareArray[5] == "6")
        {
            marker.CW(22, 7, localColor);
        }
        else if (square == "7" && SquareArray[6] == "7")
        {
            marker.CW(6, 11, localColor);
        }
        else if (square == "8" && SquareArray[7] == "8")
        {
            marker.CW(14, 11, localColor);
        }
        else if (square == "9" && SquareArray[8] == "9")
        {
            marker.CW(22, 11, localColor);
        }
 
        // MIKAEL: Martin's gamla kod

        //switch (square)
        //{
        //    case "1":
        //        marker.CW(6, 3, localColor);
        //        break;
        //    case "2":
        //        marker.CW(14, 3, localColor);
        //        break;
        //    case "3":
        //        marker.CW(22, 3, localColor);
        //        break;
        //    case "4":
        //        marker.CW(6, 7, localColor);
        //        break;
        //    case "5":
        //        marker.CW(14, 7, localColor);
        //        break;
        //    case "6":
        //        marker.CW(22, 7, localColor);
        //        break;
        //    case "7":
        //        marker.CW(6, 11, localColor);
        //        break;
        //    case "8":
        //        marker.CW(14, 11, localColor);
        //        break;
        //    case "9":
        //        marker.CW(22, 11, localColor);
        //        break;
        //}
    }



    //Ändrar värdet på spelplanen under spelets gång.
    public void ChangeValueOfBoardSquare(string square, string marker)
    {
        string playerMarker = marker;
        string boardsquare = square;

        // MIKAEL: Fixad kod som gör att man bara kan sätta värdet på en plats en gång per spel 
        // TODO: Resetta tillbaka SquareArray's values till 1-9 efter ett spel är färdigt
        // TODO: Göra så att man inte kan skriva ett nummer som redan är taget (just nu slösas ens tur om man råkar skriva ett nummer som redan använts)

        if (square == "1" && SquareArray[0] == "1")
        {
            SquareArray[0] = playerMarker;
        }
        else if (square == "2" && SquareArray[1] == "2")
        {
            SquareArray[1] = playerMarker;
        }
        else if (square == "3" && SquareArray[2] == "3")
        {
            SquareArray[2] = playerMarker;
        }
        else if (square == "4" && SquareArray[3] == "4")
        {
            SquareArray[3] = playerMarker;
        }
        else if (square == "5" && SquareArray[4] == "5")
        {
            SquareArray[4] = playerMarker;
        }
        else if (square == "6" && SquareArray[5] == "6")
        {
            SquareArray[5] = playerMarker;
        }
        else if (square == "7" && SquareArray[6] == "7")
        {
            SquareArray[6] = playerMarker;
        }
        else if (square == "8" && SquareArray[7] == "8")
        {
            SquareArray[7] = playerMarker;
        }
        else if (square == "9" && SquareArray[8] == "9")
        {
            SquareArray[8] = playerMarker;
        }


        // MIKAEL: Martin's gamla kod

        //switch (boardsquare)
        //{
        //    case "1":
        //        SquareArray[0] = playerMarker;
        //        break;
        //    case "2":
        //        SquareArray[1] = playerMarker;
        //        break;
        //    case "3":
        //        SquareArray[2] = playerMarker;
        //        break;
        //    case "4":
        //        SquareArray[3] = playerMarker;
        //        break;
        //    case "5":
        //        SquareArray[4] = playerMarker;
        //        break;
        //    case "6":
        //        SquareArray[5] = playerMarker;
        //        break;
        //    case "7":
        //        SquareArray[6] = playerMarker;
        //        break;
        //    case "8":
        //        SquareArray[7] = playerMarker;
        //        break;
        //    case "9":
        //        SquareArray[8] = playerMarker;
        //        break;
        //}



    }

    // Linh: Tog bort gamla case switch i med att den inte gäller längre
    // Likaså med den gamla for-loopen.
    // Lyckas ej få in vinnar-situationerna :( 
    // Jag får errors hela tiden, syntaxfel eller annat? I don't know.
    public void CheckWinner(string marker)
    {
        // checkWin blir till markers värde
        // Nu hoppas jag att jag har anropat rätt så att den siffran blev omvandlad till
        // X eller O vilket ni gjorde i ChangeValueOfBoardSquare
        // Annars är jag helt ute och cyklar.
        string checkWin = marker;
        // Loopar igenom varje värde i vår array
        foreach (string array in SquareArray)
        {
            // Om värdet innehåller X eller O ska den göra detta
            if (checkWin == "X" || checkWin == "O")
            {
                // Nu har jag den på while och sätter den på true för
                // jag vill den ska loopa igenom alternativen för olika sätt
                // man kan vinna på, det kluriga är att jag inte klarar av 
                // att sätta ihop t.ex. array 0,1 och 2 och se om alla innehåller X
                // så vinner player 1 som har X då och vice versa.
                while (true)
                {
                    // Loopa igenom vinnaralternativen.
                    
                    // Sätter break efter den har loopat igenom alla alternativen.
                    break;
                }
                
            }

            else
            {

            }
        }

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




