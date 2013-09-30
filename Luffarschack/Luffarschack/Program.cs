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
    public static int checkAgainstSquareArray;

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
            while (true)
            {
                ("\nDet är " + Player1.Name + "s tur, välj ruta och tryck ENTER\n-> ").CW(2, 15, "DarkGray");
                playerChoiceOfSquare = Console.ReadLine();
                // TODOPlayer: det skulle vara snyggare om vi i stället skrev: Player1.PlaceMarker(playerChoiceOfSquare, Player1.Marker);
                // Gå in i klassen Player och sök på "TODOPlayer" så hittar ni den motoden som egentligen skulle kalla på nedanstående rad

                checkAgainstSquareArray = Convert.ToInt32(playerChoiceOfSquare) - 1;
                if (MyBoard.SquareArray[checkAgainstSquareArray] == "X" || MyBoard.SquareArray[checkAgainstSquareArray] == "O")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    "Du kan inte sätta din markör på en upptagen ruta. Försök igen!".EchoWriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else
                    break;
            }
            
            MyBoard.ChangeMarkerOnBoardSquare(playerChoiceOfSquare, Player1.Marker);
            MyBoard.ChangeValueOfBoardSquare(playerChoiceOfSquare, Player1.Marker);
        }
        else
        {
            while (true)
            {
                ("\nDet är " + Player2.Name + "s tur, välj ruta och tryck ENTER\n-> ").CW(2, 15, "DarkGray");
                playerChoiceOfSquare = Console.ReadLine();

                checkAgainstSquareArray = Convert.ToInt32(playerChoiceOfSquare) - 1;
                if (MyBoard.SquareArray[checkAgainstSquareArray] == "X" || MyBoard.SquareArray[checkAgainstSquareArray] == "O")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    "Du kan inte sätta din markör på en upptagen ruta. Försök igen!".EchoWriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else
                    break;
            }
            MyBoard.ChangeMarkerOnBoardSquare(playerChoiceOfSquare, Player2.Marker);
            MyBoard.ChangeValueOfBoardSquare(playerChoiceOfSquare, Player2.Marker);
        }

        MyBoard.CheckWinner();

        if (MyBoard.P1Win == true)
        {
            //Spelare1 vinner.
            Player1.NumberOfWins++;
            // Supersnygg mini-metod istället för megastor copypaste
            MyBoard.NewGame(MyBoard);
        }

        else if (MyBoard.P2Win == true)
        {
            //Spelare2 vinner.
            Player2.NumberOfWins++;
            // Supersnygg mini-metod istället för megastor copypaste
            MyBoard.NewGame(MyBoard);
        }
            //Ingen vinner.
        else if (MyBoard.NoWin == true)
        {
            //(Oavgjort poängen skrivs här)
            //t.ex. MyBoard.NoWin++;
            // Supersnygg mini-metod istället för megastor copypaste
            MyBoard.NewGame(MyBoard);
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

