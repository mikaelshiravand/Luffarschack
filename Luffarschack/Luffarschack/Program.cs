using System;
using System.Collections.Generic;

class Program
{
    //Martin säger: Om vi skapar myBoard och players här så kommer vi åt den på fler ställen, men själva värdet på myBoard skapas fortfarande i Main.
    public static Board MyBoard;
    public static Player Player1;
    public static Player Player2;

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
        //TODOMNPlayer1.Name = Console.ReadLine();
        "Ange namn på Spelare 2\n-> ".EchoWrite();
        //TODOMNPlayer2.Name = Console.ReadLine();
        Console.ReadKey(); //TODOMNTa bort denna rad
    }
    public static string printInfoAboutPlayers()
    {
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
    static void Main()
    {
        // Mikael: Vi kan skapa Players (i Main) med tomma strings som namn eftersom de ändå kommer ändras efter spelarnas egna inmatningar.
        programInfo();
        Player1 = new Player("Ett ganska långt namn", "X"); //TODOMN nollställ värdena
        Player2 = new Player("Sebastian Sebastiansson", "O"); //TODOMN nollställ värdena
        MyBoard = new Board();
        startMenu();
        Console.Clear();
        
        Console.SetCursorPosition(3, 2); 
        printInfoAboutPlayers().EchoWrite();
        MyBoard.PrintBoard();
        
        Player.Move();

        
    }
}

