using System;
using System.Collections.Generic;

class Program
{
    //Martin säger: Om vi skapar myBoard och players här så kommer vi åt den på fler ställen, men själva värdet på myBoard skapas fortfarande i Main.
    public static Board MyBoard;
    public static Player Player1;
    public static Player Player2;
    public static int whoseTurn = 0;
    public static string playerChoiceOfSquare = "";

    static void programInfo()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.Title = "Grupp 4: Tic Tac Toe";
        Console.SetWindowSize(80, 27);
    }
    static void startMenu()
    {
        Console.ForegroundColor = ConsoleColor.White;
        "Välkommen till TicTacToe!".EchoWriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        "Ange namn på Spelare 1\n-> ".EchoWrite();
        Console.ForegroundColor = ConsoleColor.Green;
        Player1.Name = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        "Ange namn på Spelare 2\n-> ".EchoWrite();
        Console.ForegroundColor = ConsoleColor.Blue;
        Player2.Name = Console.ReadLine();
    }
    public static void printInfoAboutPlayers()
    {
        Console.SetCursorPosition(3, 2);

        Console.ForegroundColor = ConsoleColor.Green;
        ("\t\t\t\tSpelare 1: " + Player1.Name).EchoWriteLine();
        ("\t\t\t\tAntal segrar: " + Player1.NumberOfWins).EchoWriteLine();
        ("\t\t\t\tSpelmarkör: " + Player1.Marker).EchoWriteLine();
        ("\n\n").EchoWriteLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        ("\t\t\t\tSpelare 2: " + Player2.Name).EchoWriteLine();
        ("\t\t\t\tAntal segrar: " + Player2.NumberOfWins).EchoWriteLine();
        ("\t\t\t\tSpelmarkör: " + Player2.Marker).EchoWriteLine();
    }

    public static void turnQueue()
    {
        if (whoseTurn == 0)
        {
            whoWillStart();
        }
        else
        {
            whoseTurn++;
        }

        Console.ForegroundColor = ConsoleColor.DarkGray;

        if (whoseTurn % 2 == 0)
        {
            ("\nDet är " + Player1.Name + "s tur, välj ruta och tryck ENTER\n-> ").CW(2, 15, "DarkGray");
            playerChoiceOfSquare = Console.ReadLine();
            // TODOPlayer: det skulle vara snyggare om vi i stället skrev: Player1.PlaceMarker(playerChoiceOfSquare, Player1.Marker);
            // Gå in i klassen Player och sök på "TODOPlayer" så hittar ni den motoden som egentligen skulle kalla på nedanstående rad

            MyBoard.ChangeMarkerOnBoardSquare(playerChoiceOfSquare, Player1.Marker);
            MyBoard.ChangeValueOfBoardSquare(playerChoiceOfSquare, Player1.Marker);
        }
        else
        {
            ("\nDet är " + Player2.Name + "s tur, välj ruta och tryck ENTER\n-> ").CW(2, 15, "DarkGray");
            playerChoiceOfSquare = Console.ReadLine();
            
            MyBoard.ChangeMarkerOnBoardSquare(playerChoiceOfSquare, Player2.Marker);
            MyBoard.ChangeValueOfBoardSquare(playerChoiceOfSquare, Player2.Marker);
        }

        MyBoard.CheckWinner();

        if (MyBoard.P1Win == true)
        {
            //Spelare1 vinner.
            Player1.NumberOfWins++;

            Console.Clear();
            printInfoAboutPlayers();
            MyBoard.PrintBoard();
            MyBoard.ResetProperties();
            oneTurn();
        }
        else if (MyBoard.P2Win == true)
        {
            //Spelare2 vinner.
            Player2.NumberOfWins++;

            Console.Clear();
            printInfoAboutPlayers();
            MyBoard.PrintBoard();
            MyBoard.ResetProperties();
            oneTurn();
        }
    }

    public static void whoWillStart()
    {
        Random rand = new Random();
        //Martin: google verkar säga att man ska skriva .Next("lägsta talet", "högsta talet") men 3 verkar vara "mindre än 3"
        whoseTurn = rand.Next(1, 3);
    }

    public static void oneTurn()
    {
        while (MyBoard.P1Win == false || MyBoard.P2Win == false)
        {
            turnQueue();
        }
    }
    static void Main()
    {
        programInfo();
        Player1 = new Player("", "X");
        Player2 = new Player("", "O");
        MyBoard = new Board();

        startMenu();
        Console.Clear();
        printInfoAboutPlayers();
        MyBoard.PrintBoard();
        oneTurn();
    }
}

