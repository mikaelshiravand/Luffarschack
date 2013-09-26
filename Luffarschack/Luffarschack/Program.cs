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
        "Välkommen till TicTacToe!!".EchoWriteLine();
        "Ange namn på Spelare1\n->".EchoWrite();
        "Ange namn på Spelare2\n->".EchoWrite();
    }
    static void Main()
    {
        Player1 = new Player("Exempelnamn1", "X");
        Player2 = new Player("Exempelnamn2", "O");
        MyBoard = new Board();
        MyBoard.PrintBoard();
        menu();
    }
}

