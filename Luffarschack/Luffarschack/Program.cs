using System;
using System.Collections.Generic;

class Program
{
    //Martin säger: Om vi skapar myBoard och players här så kommer vi åt den på fler ställen, men själva värdet på myBoard skapas fortfarande i Main.
    public static Board MyBoard;
    public static Player Player1;
    public static Player Player2;

    public static void menu()
    {
        "Välkommen till TicTacToe!".EchoWriteLine();
        // Mikael: Ändrade så att programmet börjar med att spelarna får mata in sina namn, som lagras i Player klassen.
        "Ange namn på Spelare 1\n-> ".EchoWrite();
        Player1.Name = Console.ReadLine();
        "Ange namn på Spelare 2\n-> ".EchoWrite();
        Player2.Name = Console.ReadLine();
    }
    static void Main()
    {
        // Mikael: Vi kan skapa Players (i Main) med tomma strings som namn eftersom de ändå kommer ändras efter spelarnas egna inmatningar.
        Player1 = new Player("", "X");
        Player2 = new Player("", "O");
        MyBoard = new Board();
        MyBoard.PrintBoard();
        menu();
        Player.Move();

        
    }
}

