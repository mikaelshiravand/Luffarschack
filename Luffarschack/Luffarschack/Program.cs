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
        Console.Title = "Grupp 4: Tic Tac Toe";
        Console.SetWindowSize(80, 27);
    }
    static void startMenu()
    {
        "Välkommen till TicTacToe!".EchoWriteLine();
        // Mikael: Ändrade så att programmet börjar med att spelarna får mata in sina namn, som lagras i Player klassen.
        "Ange namn på Spelare 1\n-> ".EchoWrite();
        Player1.Name = Console.ReadLine();
        "Ange namn på Spelare 2\n-> ".EchoWrite();
        Player2.Name = Console.ReadLine();
    }
    public static string printInfoAboutPlayers()
    {
        Console.SetCursorPosition(3, 2);
        string output = "";

        output += "\t\t\t\tSpelare 1: " + Player1.Name + "\n";
        output += "\t\t\t\tAntal segrar: " + Player1.NumberOfWins + "\n";
        output += "\t\t\t\tSpelmarkör: " + Player1.Marker + "\n";
        output += "\n\n";
        output += "\t\t\t\tSpelare 2: " + Player2.Name + "\n";
        output += "\t\t\t\tAntal segrar: " + Player2.NumberOfWins + "\n";
        output += "\t\t\t\tSpelmarkör: " + Player2.Marker + "\n";


        return output;
    }

    // Gör så att spelarna spelar varannan gång
    public static void turnQueue()
    {
        if (whoseTurn == 0)
        {
            // Programmet kommer in här innan första rundan i varje spelomgång,
            // eller ska göra det när vi färdiga rättare sagt (tror jag iaf // Martin)
            whoWillStart();
        }
        else
        {
            // Programmet kommer in här innan varje runda i spelomgången (utom första rundan)
            whoseTurn++;
        }

        if (whoseTurn % 2 == 0)
        {
            ("\nDet är " + Player1.Name + " s tur, välj ruta och tryck ENTER").EchoWriteLine();
            playerChoiceOfSquare = Console.ReadLine();
            // TODOPlayer: det skulle vara snyggare om vi i stället skrev: Player1.PlaceMarker(playerChoiceOfSquare, Player1.Marker);
            // Gå in i klassen Player och sök på "TODOPlayer" så hittar ni den motoden som egentligen skulle kalla på nedanstående rad
            MyBoard.ChangeValueOfBoardSquare(playerChoiceOfSquare, Player1.Marker);
        }
        else
        {
            ("\nDet är " + Player2.Name + "s tur, välj ruta och tryck ENTER").EchoWriteLine();
            playerChoiceOfSquare = Console.ReadLine();
            MyBoard.ChangeValueOfBoardSquare(playerChoiceOfSquare, Player2.Marker);
        }

    }

    // Kallas på en gång innan varje spel.
    public static void whoWillStart()
    {
        Random rand = new Random();
        //Martin: google verkar säga att man ska skriva .Next("lägsta talet", "högsta talet") men 3 verkar vara "mindre än 3"
        whoseTurn = rand.Next(1, 3);
    }

    // Martin: oneTurn är en av nio rundor i spelet
    public static void oneTurn()
    {
        while (true) // ska ändras till "while (checkWinner() != null) eller liknande
        {
            Console.Clear();
            printInfoAboutPlayers().EchoWrite();
            MyBoard.PrintBoard();
            turnQueue();
        }
    }
    static void Main()
    {
        // Mikael: Vi kan skapa Players (i Main) med tomma strings som namn eftersom de ändå kommer ändras efter spelarnas egna inmatningar.
        programInfo();
        Player1 = new Player("", "X");
        Player2 = new Player("", "O");
        MyBoard = new Board();

        // Martin: Här startar själv programmet med utskrifter på skärmen 
        startMenu();

        oneTurn();



    }
}

